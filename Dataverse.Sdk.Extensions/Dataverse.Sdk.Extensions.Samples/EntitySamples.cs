using Dataverse.Sdk.Extensions.Samples.EarlyBoundEntities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System.Linq;

namespace Dataverse.Sdk.Extensions.Samples
{
    public class EntitySamples
    {
        /// <summary>
        /// Sample that demonstrates how to add an activity party to an
        /// activity table
        /// </summary>
        /// <param name="contactReference">Reference to a dataverse contact row</param>
        /// <param name="accountReference">Reference to a dataverse account row</param>
        public void AddPartiesToActivityTable(EntityReference contactReference, EntityReference accountReference)
        {
            var email = new Entity("email");
            email["subject"] = "A test email";
            email.AddParties("to", contactReference, accountReference);
        }

        /// <summary>
        /// Sample that demonstrates how to add an activity party to an
        /// activity table
        /// </summary>
        /// <param name="contactReference">Reference to a dataverse row</param>
        public void AddPartyToActivityTable(EntityReference contactReference)
        {
            var email = new Entity("email");
            email["subject"] = "A test email";
            email.AddParty("to", contactReference);
        }

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
        /// Sample that demonstrates how to check for multiple columns that
        /// have been emptied before processing
        /// </summary>
        /// <remarks>
        /// This can be useful in code that process plugin input data to
        /// check faster if column(s) have been emptied
        /// Standard code would have been:
        /// if(account.Contains("address1_line1") && account.GetAttributeValue<string>("address1_line1") == null
        /// && account.Contains("address1_city") && account.GetAttributeValue<string>("address1_city") == null){
        /// // Do something
        /// }
        /// </remarks>
        /// <param name="account">Account row data</param>
        public void ProcessOnlyIfColumnsHaveBeenEmptied(Account account)
        {
            // Process only if address1_line1 and address1_city columns
            // have been emptied
            if (account.ContainsNullValue(a => a.Address1_Line1, a => a.Address1_City))
            {
                // Do something
            }
        }

        /// <summary>
        /// Sample that demonstrates how to check for multiple columns that
        /// have been set before processing
        /// </summary>
        /// <remarks>
        /// This can be useful in code that process plugin input data to
        /// check faster if column(s) have been set
        /// Standard code would have been:
        /// if(account.Contains("address1_line1") && account.GetAttributeValue<string>("address1_line1") != null
        /// && account.Contains("address1_city") && account.GetAttributeValue<string>("address1_city") != null){
        /// // Do something
        /// }
        /// </remarks>
        /// <param name="account">Account row data</param>
        public void ProcessOnlyIfColumnsHaveBeenSet(Account account)
        {
            // Process only if address1_line1 and address1_city columns
            // have been set with values different from null
            if (account.ContainsValue(a => a.Address1_Line1, a => a.Address1_City))
            {
                // Do something
            }
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