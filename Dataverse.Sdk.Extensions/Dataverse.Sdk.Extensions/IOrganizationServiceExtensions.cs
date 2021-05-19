using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Dataverse.Sdk.Extensions
{
    public static class OrganizationServiceExtensions
    {
        /// <summary>
        /// Creates a table row from another table row using standard columns
        /// mapping
        /// </summary>
        /// <typeparam name="T">Type of the targeted table</typeparam>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="sourceRef">Reference to the source row</param>
        /// <param name="type">Mapping columns type</param>
        /// <param name="additionalColumns">Additional columns to add to the generated row</param>
        /// <returns>Created row</returns>
        public static T CreateFromInitialization<T>(this IOrganizationService service, EntityReference sourceRef,
                            TargetFieldType type, Dictionary<string, object> additionalColumns = null) where T : Entity
        {
            string entityName = typeof(T).GetField("EntityLogicalName").GetRawConstantValue().ToString();

            Entity entity = service.CreateFromInitialization(entityName, sourceRef, type, additionalColumns);

            return entity.ToEntity<T>();
        }

        /// <summary>
        /// Creates a table row from another table row using standard columns
        /// mapping
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="entityLogicalname">Logical name of the targeted table</param>
        /// <param name="sourceRef">Reference to the source row</param>
        /// <param name="type">Mapping columns type</param>
        /// <param name="additionalColumns">Additional columns to add to the generated row</param>
        /// <returns>Created row</returns>
        public static Entity CreateFromInitialization(this IOrganizationService service, string entityLogicalname, EntityReference sourceRef,
                            TargetFieldType type, Dictionary<string, object> additionalColumns = null)
        {
            var request = new InitializeFromRequest
            {
                EntityMoniker = sourceRef,
                TargetEntityName = entityLogicalname,
                TargetFieldType = type
            };

            var response = (InitializeFromResponse)service.Execute(request);

            if (additionalColumns?.Count > 0)
            {
                foreach (var key in additionalColumns.Keys)
                {
                    response.Entity[key] = additionalColumns[key];
                }
            }

            response.Entity.Id = service.Create(response.Entity);

            return response.Entity;
        }

        /// <summary>
        /// Deletes a row by its reference
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="reference">Reference of the row to delete</param>
        public static void Delete(this IOrganizationService service, EntityReference reference)
        {
            service.Execute(new DeleteRequest() { Target = reference });
        }

        /// <summary>
        /// Delete a row
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="record">row to delete</param>
        public static void Delete(this IOrganizationService service, Entity row)
        {
            service.Execute(new DeleteRequest() { Target = row.ToEntityReference() });
        }

        /// <summary>
        /// Delete a row by its alternate key
        /// </summary>
        /// <typeparam name="T">Type of the table row to delete</typeparam>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="keyName">alternate key name</param>
        /// <param name="keyValue">alternate key value</param>
        public static void Delete<T>(this IOrganizationService service, string keyName, object keyValue) where T : Entity
        {
            string entityName = typeof(T).GetField("EntityLogicalName").GetRawConstantValue().ToString();

            service.Delete(entityName, keyName, keyValue);
        }

        /// <summary>
        /// Delete a row by its alternate key
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="entityLogicalname">row to delete</param>
        /// <param name="keys">Alternate keys collection</param>
        public static void Delete(this IOrganizationService service, string entityLogicalname, KeyAttributeCollection keys)
        {
            service.Delete(new EntityReference(entityLogicalname, keys));
        }

        /// <summary>
        /// Delete a row by its alternate key
        /// </summary>
        /// <typeparam name="T">Type of the table row to delete</typeparam>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="keys">Alternate keys collection</param>
        public static void Delete<T>(this IOrganizationService service, KeyAttributeCollection keys) where T : Entity
        {
            string entityName = typeof(T).GetField("EntityLogicalName").GetRawConstantValue().ToString();

            service.Delete(entityName, keys);
        }

        /// <summary>
        /// Delete a row by its alternate key
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="entityLogicalname">Logical name of the table row to delete</param>
        /// <param name="keyName">alternate key name</param>
        /// <param name="keyValue">alternate key value</param>
        public static void Delete(this IOrganizationService service, string entityLogicalname, string keyName, object keyValue)
        {
            service.Delete(new EntityReference(entityLogicalname, keyName, keyValue));
        }

        /// <summary>
        /// Gets the list of current user affected roles
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        /// <returns>List of user security roles</returns>
        public static List<string> GetCurrentUserRoles(this IOrganizationService service)
        {
            var query = new QueryExpression("role")
            {
                NoLock = true,
                ColumnSet = new ColumnSet("name"),
                LinkEntities =
                {
                    new LinkEntity
                    {
                        LinkFromEntityName = "role",
                        LinkFromAttributeName = "roleid",
                        LinkToAttributeName = "roleid",
                        LinkToEntityName = "systemuserroles",
                        LinkEntities =
                        {
                            new LinkEntity
                            {
                                LinkFromEntityName = "systemuserroles",
                                LinkFromAttributeName = "systemuserid",
                                LinkToAttributeName = "systemuserid",
                                LinkToEntityName = "systemuser",
                                LinkCriteria = new FilterExpression
                                {
                                    Conditions =
                                    {
                                        new ConditionExpression("systemuserid", ConditionOperator.EqualUserId)
                                    }
                                }
                            }
                        }
                    }
                }
            };

            return service.RetrieveMultiple(query).Entities.Select(e => e.GetAttributeValue<string>("name")).ToList();
        }

        /// <summary>
        /// Retrieves an Environment variable value
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="variableName">Name of the Environment variable requested</param>
        /// <returns>Value of the Environment variable</returns>
        public static string GetEnvironmentVariable(this IOrganizationService service, string variableName)
        {
            var query = new QueryExpression("environmentvariablevalue")
            {
                ColumnSet = new ColumnSet("value"),
                LinkEntities =
                {
                    new LinkEntity
                    {
                        LinkFromEntityName = "environmentvariablevalue",
                        LinkFromAttributeName = "environmentvariabledefinitionid",
                        LinkToAttributeName = "environmentvariabledefinitionid",
                        LinkToEntityName = "environmentvariabledefinition",
                        LinkCriteria = new FilterExpression
                        {
                            Conditions =
                            {
                                new ConditionExpression("schemaname", ConditionOperator.Equal, variableName)
                            }
                        }
                    }
                }
            };

            var values = service.RetrieveMultiple(query);
            if (values.Entities.Count == 0)
            {
                throw new Exception($"Aucune variable d'environnement avec le nom '{variableName}' n'a �t� trouv�e.");
            }

            return values.Entities.First().GetAttributeValue<string>("value");
        }

        /// <summary>
        /// Retrieves multiple Environment variables values
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="variableNames">Names of the Environment variables requested</param>
        /// <returns>List of Environment variables</returns>
        public static Dictionary<string, string> GetEnvironmentVariables(this IOrganizationService service, params string[] variableNames)
        {
            var query = new QueryExpression("environmentvariablevalue")
            {
                ColumnSet = new ColumnSet("value"),
                LinkEntities =
                {
                    new LinkEntity
                    {
                        LinkFromEntityName = "environmentvariablevalue",
                        LinkFromAttributeName = "environmentvariabledefinitionid",
                        LinkToAttributeName = "environmentvariabledefinitionid",
                        LinkToEntityName = "environmentvariabledefinition",
                        Columns = new ColumnSet("schemaname"),
                        EntityAlias = "def",
                        LinkCriteria = new FilterExpression(LogicalOperator.Or)
                    }
                }
            };

            foreach (var variableName in variableNames)
                query.LinkEntities.First().LinkCriteria.AddCondition("schemaname", ConditionOperator.Equal, variableName);

            var values = service.RetrieveMultiple(query);
            if (values.Entities.Count == 0)
            {
                throw new Exception($"No Environment variables with names '{string.Join("','", variableNames)}' have been found.");
            }
            if (values.Entities.Count != variableNames.Length)
            {
                throw new Exception($"{values.Entities.Count} Environment variable have been found whereas {variableNames.Length} was expected ({string.Join(",", variableNames)}).");
            }

            return values.Entities.ToDictionary(e => e.GetAliasedValue<string>("def", "schemaname"),
                e => e.GetAttributeValue<string>("value"));
        }

        /// <summary>
        /// Creates or Updates a row, depending if it already exists in the targeted environment
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="record">Row to process</param>
        /// <returns>A value that indicates if the row was created (true) or updated (false)</returns>
        public static bool Upsert(this IOrganizationService service, Entity record)
        {
            var request = new UpsertRequest
            {
                Target = record
            };

            var response = (UpsertResponse)service.Execute(request);

            if (response.RecordCreated)
            {
                record.Id = response.Target.Id;
            }

            return response.RecordCreated;
        }

        /// <summary>
        /// Retrieves a table row typed as the specific class. This is particularly useful for Early Bound classes.
        /// </summary>
        /// <typeparam name="T">Entity</typeparam>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="id">Primary key of the row to retrieve</param>
        /// <param name="columnSet">The columns to retrieve for the row</param>
        /// <returns>The table row for the record, typed as the specified class</returns>
        public static T Retrieve<T>(this IOrganizationService service, Guid id, ColumnSet columnSet) where T : Entity
        {
            string entityName = typeof(T).GetField("EntityLogicalName").GetRawConstantValue().ToString();
            return service.Retrieve(entityName, id, columnSet).ToEntity<T>();
        }

        /// <summary>
        /// Retrieves a list of records for a query, typed as the specific class. This is particularly useful for Early Bound classes.
        /// </summary>
        /// <typeparam name="T">Entity</typeparam>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="query">Primary key of the row to retrieve</param>
        /// <returns>A List of table row for the record, typed as the specified class</returns>
        public static List<T> RetrieveMultiple<T>(this IOrganizationService service, QueryBase query) where T : Entity
        {
            return service.RetrieveMultiple(query).Entities.Select(e => e.ToEntity<T>()).ToList();
        }

        /// <summary>Retrieves all rows for the query</summary>
        /// <typeparam name="T">A class derived from Entity</typeparam>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="query">A QueryBase object (QueryExpression, QueryByAttribute)</param>
        /// <param name="callback">Optional: A callback method to invoke with each page of results</param>
        /// <returns>All rows meeting the query criteria, typed as the specified class. If there are multiple pages of results, the pages are combined to a single list</returns>
        public static IEnumerable<T> RetrieveAll<T>(this IOrganizationService service, QueryBase query, Action<EntityCollection> callback = null) where T : Entity
        {
            foreach (var result in RetrieveAll(service, query, callback))
            {
                yield return result.ToEntity<T>();
            }
        }

        /// <summary>Retrieves all rows for the query</summary>
        /// <typeparam name="T">A class derived from Entity</typeparam>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="query">A FetchExpression object</param>
        /// <param name="callback">Optional: A callback method to invoke with each page of results</param>
        /// <returns>All rows meeting the query criteria, typed as the specified class. If there are multiple pages of results, the pages are combined to a single list</returns>
        public static IEnumerable<T> RetrieveAll<T>(this IOrganizationService service, FetchExpression query, Action<EntityCollection> callback = null) where T : Entity
        {
            foreach (var result in RetrieveAll(service, query, callback))
            {
                yield return result.ToEntity<T>();
            }
        }

        /// <summary>Retrieves all rows for the query</summary>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="query">A QueryBase object (QueryExpression, QueryByAttribute)</param>
        /// <param name="callback">Optional: A callback method to invoke with each page of results</param>
        /// <returns>All rows meeting the query criteria. If there are multiple pages of results, the pages are combined to a single list</returns>
        public static IEnumerable<Entity> RetrieveAll(this IOrganizationService service, QueryBase query, Action<EntityCollection> callback = null)
        {
            EntityCollection collection = new EntityCollection
            {
                MoreRecords = true
            };

            while (collection.MoreRecords)
            {
                if (query is QueryExpression)
                {
                    var qe = query as QueryExpression;
                    qe.PageInfo.PageNumber++;
                    qe.PageInfo.PagingCookie = collection.PagingCookie;
                }
                else if (query is QueryByAttribute)
                {
                    var qa = query as QueryByAttribute;
                    if (qa.PageInfo == null)
                    {
                        qa.PageInfo = new PagingInfo();
                    }
                    qa.PageInfo.PageNumber++;
                    qa.PageInfo.PagingCookie = collection.PagingCookie;
                }

                collection = service.RetrieveMultiple(query);
                callback?.Invoke(collection);

                foreach (Entity entity in collection.Entities)
                {
                    yield return entity;
                }
            }
        }

        /// <summary>Retrieves all rows for the query</summary>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="query">A FetchExpression object</param>
        /// <param name="callback">Optional: A callback method to invoke with each page of results</param>
        /// <returns>All rows meeting the query criteria. If there are multiple pages of results, the pages are combined to a single list</returns>
        public static IEnumerable<Entity> RetrieveAll(this IOrganizationService service, FetchExpression query, Action<EntityCollection> callback = null)
        {
            EntityCollection collection = new EntityCollection
            {
                MoreRecords = true
            };

            /// For performance reasons it's better to load XML once
            XDocument document = XDocument.Parse(query.Query);

            while (collection.MoreRecords)
            {
                string page = document.Root.Attribute("page")?.Value;
                int pageNumber = page != null ? int.Parse(page) : 0;

                document.Root.SetAttributeValue("paging-cookie", collection.PagingCookie);
                document.Root.SetAttributeValue("page", ++pageNumber);

                query.Query = document.ToString();

                collection = service.RetrieveMultiple(query);
                callback?.Invoke(collection);

                foreach (Entity entity in collection.Entities)
                {
                    yield return entity;
                }
            }
        }
    }
}