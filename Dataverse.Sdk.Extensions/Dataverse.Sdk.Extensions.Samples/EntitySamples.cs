using Dataverse.Sdk.Extensions.Samples.EarlyBoundEntities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System.Linq;

namespace Dataverse.Sdk.Extensions.Samples
{
    public class EntitySamples
    {
        /// <summary>
        /// Sample that demonstrates how to clone a Dataverse row
        /// </summary>
        /// <remarks>
        /// In this sample, the account is cloned by adding " (clone)" after
        /// the name and excluding specifically "accountnumber" and "ownerid"
        /// columns
        /// </remarks>
        /// <param name="accountRow">Dataverse row of type Account</param>
        /// <param name="service">Dataverse Organization service</param>
        public void CloneDataverseRow(Account accountRow, IOrganizationService service)
        {
            Entity clonedRow = accountRow.Clone(service, true, "accountnumber", "ownerid");
        }

        /// <summary>
        /// Sample that demonstrates how to read the value of a linked entity
        /// column in a more concise way than the standard way
        /// </summary>
        /// <param name="service">Dataverse Organization service</param>
        public void ReadAliasedValueFromEntity(IOrganizationService service)
        {
            var query = new QueryExpression("account")
            {
                TopCount = 1,
                ColumnSet = new ColumnSet("name"),
                LinkEntities =
                {
                    new LinkEntity
                    {
                        LinkFromEntityName = "account",
                        LinkFromAttributeName = "primarycontactid",
                        LinkToAttributeName = "contactid",
                        LinkToEntityName = "contact",
                        EntityAlias = "primarycontact",
                        Columns = new ColumnSet("fullname")
                    }
                }
            };

            EntityCollection ec = service.RetrieveMultiple(query);
            Entity record = ec.Entities.FirstOrDefault();

            if (record != null)
            {
                // The standard way
                string contactFullname = record.GetAttributeValue<AliasedValue>("primarycontact.fullname")?.Value?.ToString();

                // With the extension
                contactFullname = record.GetAliasedValue<string>("primarycontact", "fullname");
            }
        }
    }
}