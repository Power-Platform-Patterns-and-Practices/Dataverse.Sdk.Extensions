using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata.Query;
using System;
using System.Linq;

namespace Dataverse.Sdk.Extensions
{
    public static class EntityExtensions
    {
        /// <summary>
        /// Get value of an attribute from a linked entity
        /// </summary>
        /// <typeparam name="T">Type of the attribute to get</typeparam>
        /// <param name="record">Record containing the attribute</param>
        /// <param name="alias">Alias of the linked entity</param>
        /// <param name="attribute">Logical name of the attribute</param>
        /// <returns>Value of the attribute</returns>
        public static T GetAliasedValue<T>(this Entity record, string alias, string attribute)
        {
            var aliasedAttribute = $"{alias}.{attribute}";

            if (!record.Contains(aliasedAttribute))
            {
                return default(T);
            }

            var aliasedValue = record.GetAttributeValue<AliasedValue>(aliasedAttribute);

            if (!(aliasedValue.Value is T))
            {
                var message = $"The attribute {aliasedValue.AttributeLogicalName} in entity {aliasedValue.EntityLogicalName} is not of type {typeof(T)}";
                throw new InvalidCastException(message);
            }

            return (T)aliasedValue.Value;
        }

        /// <summary>
        /// Clone a row
        /// </summary>
        /// <param name="row">Dataverse row</param>
        /// <param name="service">Dataverse Organization Service</param>
        /// <param name="addCloneLabel">Indicates if a "(clone)" text must be added in the newly created row name</param>
        /// <param name="columnsToRemove">Specific columns to exclude when cloning the row</param>
        /// <returns>Cloned row</returns>
        public static Entity Clone(this Entity row, IOrganizationService service, bool addCloneLabel = true, params string[] columnsToRemove)
        {
            // There are specific columns we don't want to clone anyway
            var standardToRemove = new[] { "createdon", "createdonbehalfby", "createdby", "modifiedon", "modifiedonbehalfby", "modifiedby", "overridencreatedon", "overridencreatedby", "ownerid" };
            var toRemove = standardToRemove.Concat(columnsToRemove).ToArray();

            // Query metadata for the table to understand what columns are valid for create
            var mdQuery = new EntityQueryExpression
            {
                Properties = new MetadataPropertiesExpression("Attributes", "PrimaryIdAttribute", "PrimaryNameAttribute"),
                Criteria = new MetadataFilterExpression
                {
                    Conditions =
                    {
                        new MetadataConditionExpression("LogicalName", MetadataConditionOperator.Equals,
                            row.LogicalName)
                    }
                },
                AttributeQuery = new AttributeQueryExpression
                {
                    Properties = new MetadataPropertiesExpression("IsValidForCreate", "LogicalName")
                }
            };

            var response = (RetrieveMetadataChangesResponse)service.Execute(new RetrieveMetadataChangesRequest
            {
                Query = mdQuery,
                ClientVersionStamp = null
            });

            var cloned = new Entity(row.LogicalName);

            // Processing columns
            foreach (var column in response.EntityMetadata.First().Attributes)
            {
                // Do not add columns to remove
                if (toRemove.Contains(column.LogicalName))
                {
                    continue;
                }

                // Do not add primary column, which is the unique identifier
                if (column.LogicalName == response.EntityMetadata.First().PrimaryIdAttribute)
                {
                    continue;
                }

                // If the column is the primary column, process adding additional "(clone)" text
                if (column.LogicalName == response.EntityMetadata.First().PrimaryNameAttribute)
                {
                    cloned[column.LogicalName] = $"{row.GetAttributeValue<string>(column.LogicalName)}{(addCloneLabel ? " (clone)" : "")}";
                    continue;
                }

                // Process column only if it's valid for create
                if ((column.IsValidForCreate ?? false) && row.Contains(column.LogicalName))
                {
                    if (row[column.LogicalName] is Guid)
                    {
                        continue;
                    }

                    cloned[column.LogicalName] = row[column.LogicalName];
                }
            }

            return cloned;
        }
    }
}