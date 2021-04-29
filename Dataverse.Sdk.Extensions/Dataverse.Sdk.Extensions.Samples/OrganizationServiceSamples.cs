using Dataverse.Sdk.Extensions.Samples.EarlyBoundEntities;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using System;
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
    }
}