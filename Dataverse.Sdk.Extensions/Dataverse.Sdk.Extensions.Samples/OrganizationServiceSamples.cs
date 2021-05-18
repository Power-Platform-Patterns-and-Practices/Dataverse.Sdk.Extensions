using Dataverse.Sdk.Extensions.Samples.EarlyBoundEntities;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Dataverse.Sdk.Extensions.Samples
{
    public class OrganizationServiceSamples
    {
        /// <summary>
        /// This sample demonstrates how to create a related row using system
        /// mapping
        /// </summary>
        /// <remarks>
        /// Using system mapping avoids to map columns directly in code.
        /// This way, one can change the mapping by using only Dataverse
        /// customization
        /// </remarks>
        /// <param name="parentAccountRef">Reference to the parent account</param>
        /// <param name="service">Dataverse Organization service</param>
        public void CreateChildAccountUsingSystemMappingAndInitializeFromMessage(EntityReference parentAccountRef, IOrganizationService service)
        {
            // Sets additional columns to add in the generated row
            var additionalColumns = new Dictionary<string, object>{
                { "new_issubsidiary", true },
                { "new_needsvalidation", true}
                };

            Account childAccount = service.CreateFromInitialization<Account>(parentAccountRef, TargetFieldType.All, additionalColumns);
        }

        /// <summary>
        /// This sample demonstrates how to delete a row using its alternate key
        /// </summary>
        /// <remarks>
        /// This sample deletes an account that has an alternate key made of
        /// column "accountnumber". The account number of the account to delete
        /// is ABCDEFGH
        /// </remarks>
        /// <param name="service">Dataverse Organization service</param>
        public void DeleteFromAlternateKey(IOrganizationService service)
        {
            service.Delete<Account>("accountnumber", "ABCDEFGH");

            // or

            service.Delete("account", "accountnumber", "ABCDEFGH");
        }

        /// <summary>
        /// This sample demonstrates how to delete a row using its alternate key
        /// </summary>
        /// <remarks>
        /// This sample deletes an account that has an alternate key made of
        /// column "accountnumber" and "address1_country". The account number
        /// of the account to delete is ABCDEFGH and the country is France
        /// </remarks>
        /// <param name="service">Dataverse Organization service</param>
        public void DeleteFromAlternateKeyCollection(IOrganizationService service)
        {
            service.Delete<Account>(new KeyAttributeCollection
                {
                    {"accountnumber","ABCDEFGH" },
                    {"address1_country","France" }
                }
            );

            // or

            service.Delete("account", new KeyAttributeCollection
                {
                    {"accountnumber","ABCDEFGH" },
                    {"address1_country","France" }
                }
            );
        }

        /// <summary>
        /// This sample demonstrates how to delete a row
        /// </summary>
        /// <remarks>
        /// The standard way requires to provide EntityLogicalName and Id. This
        /// samples allows to use the Entity object directly
        /// </remarks>
        /// <param name="row">Row to delete</param>
        /// <param name="service">Dataverse Organization service</param>
        public void DeleteFromEntity(Entity row, IOrganizationService service)
        {
            service.Delete(row);
        }

        /// <summary>
        /// This sample demonstrates how to delete a row using its reference
        /// </summary>
        /// <remarks>
        /// The standard way requires to provide EntityLogicalName and Id. This
        /// samples allows to use the EntityReference directly
        /// </remarks>
        /// <param name="reference">Reference to the row to delete</param>
        /// <param name="service">Dataverse Organization service</param>
        public void DeleteFromEntityReference(EntityReference reference, IOrganizationService service)
        {
            service.Delete(reference);
        }

        /// <summary>
        /// This sample demonstrates how to retrieve current user roles in one
        /// line of code
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        public void RetrieveCurrentUserRoles(IOrganizationService service)
        {
            List<string> roles = service.GetCurrentUserRoles();
        }

        /// <summary>
        /// This sample demonstrates how to retrieve multiple Environment
        /// variables in one line
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="variablesSchemaNames">Schema names of the of Environment variables to retrieve</param>
        public void RetrieveMultipleEnvironmentVariables(IOrganizationService service, params string[] variablesSchemaNames)
        {
            Dictionary<string, string> environmentVariables = service.GetEnvironmentVariables(variablesSchemaNames);

            foreach (var key in environmentVariables.Keys)
            {
                Console.WriteLine($"{key} : {environmentVariables[key]}");
            }
        }

        /// <summary>
        /// This sample demonstrates how to retrieve on Environment
        /// variable in one line
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="variableSchemaName">Schema name of the Environment variable to retrieve</param>
        public void RetrieveOneEnvironmentVariable(IOrganizationService service, string variableSchemaName)
        {
            string environmentVariableValue = service.GetEnvironmentVariable(variableSchemaName);
        }

        /// <summary>
        /// This sample demonstrates how to retrieve an account row typed as an Account object
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        /// <param name="accountId">The primary key of an account to retrieve</param>
        public void RetrieveTyped(IOrganizationService service, Guid accountId)
        {
            Account row = service.Retrieve<Account>(accountId, new ColumnSet(Account.Fields.Name));
        }

        /// <summary>
        /// This sample demonstrates how to retrieve multiple accounts with the results typed as an Account object
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        public void RetrieveMultipleTyped(IOrganizationService service)
        {
            QueryExpression qe = new QueryExpression(Account.EntityLogicalName)
            {
                TopCount = 10,
                ColumnSet = new ColumnSet(Account.Fields.Name)
            };

            List<Account> rows = service.RetrieveMultiple<Account>(qe);
        }

        /// <summary>
        /// This sample demonstrates how to retrieve all accounts using a Query Expression
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        public void RetrieveAll_QueryExpression(IOrganizationService service)
        {
            QueryExpression queryExpression = new QueryExpression(Account.EntityLogicalName)
            {
                ColumnSet = new ColumnSet(Account.Fields.Name)
            };

            IEnumerable<Entity> enumerableResults = service.RetrieveAll(queryExpression);
            var genericResultsAsList = enumerableResults.ToList();
        }

        /// <summary>
        /// This sample demonstrates how to retrieve all accounts using a Query Expression, with the results typed as an Account object
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        public void RetrieveAllTyped_QueryExpression(IOrganizationService service)
        {
            QueryExpression queryExpression = new QueryExpression(Account.EntityLogicalName)
            {
                ColumnSet = new ColumnSet(Account.Fields.Name)
            };

            IEnumerable<Account> enumerableResults = service.RetrieveAll<Account>(queryExpression);
            var resultsAsList = enumerableResults.ToList();
        }

        /// <summary>
        /// This sample demonstrates how to retrieve all accounts using a Query By Attribute
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        public void RetrieveAll_QueryByAttribute(IOrganizationService service)
        {
            QueryByAttribute queryByAttribute = new QueryByAttribute(Account.EntityLogicalName);
            queryByAttribute.AddAttributeValue(Account.Fields.Name, "Account Name");
            queryByAttribute.ColumnSet = new ColumnSet(Account.Fields.Name);

            IEnumerable<Entity> enumerableResults = service.RetrieveAll<Entity>(queryByAttribute);
            var resultsAsList = enumerableResults.ToList();
        }
        
        /// <summary>
        /// This sample demonstrates how to retrieve all accounts using a Query By Attribute, with the results typed as an Account object
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        public void RetrieveAllTyped_QueryByAttribute(IOrganizationService service)
        {
            QueryByAttribute queryByAttribute = new QueryByAttribute(Account.EntityLogicalName);
            queryByAttribute.AddAttributeValue(Account.Fields.Name, "Account Name");
            queryByAttribute.ColumnSet = new ColumnSet(Account.Fields.Name);

            IEnumerable<Account> enumerableResults = service.RetrieveAll<Account>(queryByAttribute);
            var resultsAsList = enumerableResults.ToList();
        }

        /// <summary>
        /// This sample demonstrates how to retrieve all accounts using a Fetch Expression
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        public void RetrieveAll_FetchExpression(IOrganizationService service)
        {
            var fetchXml = $@"
                <fetch>
                  <entity name='account'>
                    <attribute name='name' />
                  </entity>
                </fetch>";
            FetchExpression fe = new FetchExpression(fetchXml);

            IEnumerable<Entity> enumerableResults = service.RetrieveAll(fe);
            var resultsAsList = enumerableResults.ToList();
        }

        /// <summary>
        /// This sample demonstrates how to retrieve all accounts using a Fetch Expression, with the results typed as an Account object
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        public void RetrieveAllTyped_FetchExpression(IOrganizationService service)
        {
            var fetchXml = $@"
                <fetch>
                  <entity name='account'>
                    <attribute name='name' />
                  </entity>
                </fetch>";
            FetchExpression fetchExpression = new FetchExpression(fetchXml);

            IEnumerable<Account> enumerableResults = service.RetrieveAll<Account>(fetchExpression);
            var resultsAsList = enumerableResults.ToList();
        }
    }
}