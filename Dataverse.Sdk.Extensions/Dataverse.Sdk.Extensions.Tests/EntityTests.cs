using FakeXrmEasy;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Linq;
using Xunit;

namespace Dataverse.Sdk.Extensions.Samples.Tests
{
    public class EntitySamplesTests
    {
        [Fact]
        public void GetAliasedValue_Can_Read_Aliased_Value_From_Record()
        {
            // Arrange
            var fakedContext = new XrmFakedContext();
            var contact = new Entity("contact")
            {
                Id = Guid.NewGuid(),
                ["fullname"] = "Unit Test"
            };
            var account = new Entity("account")
            {
                Id = Guid.NewGuid(),
                ["primarycontactid"] = contact.ToEntityReference(),
                ["name"] = "Your Company"
            };
            fakedContext.Initialize(new Entity[] { contact, account });

            //Act
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

            Entity record = fakedContext.GetOrganizationService().RetrieveMultiple(query).Entities.FirstOrDefault();
            string fullname = record.GetAliasedValue<string>("primarycontact", "fullname");

            //Assert 
            Assert.Equal(contact.GetAttributeValue<string>("fullname"), fullname);
        }

        [Fact]
        public void GetAliasedValue_Throws_If_Wrong_Aliased_Type()
        {
            // Arrange
            var fakedContext = new XrmFakedContext();
            var contact = new Entity("contact")
            {
                Id = Guid.NewGuid(),
                ["fullname"] = "Unit Test"
            };
            var account = new Entity("account")
            {
                Id = Guid.NewGuid(),
                ["primarycontactid"] = contact.ToEntityReference(),
                ["name"] = "Your Company"
            };
            fakedContext.Initialize(new Entity[] { contact, account });

            //Act
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

            Entity record = fakedContext.GetOrganizationService().RetrieveMultiple(query).Entities.FirstOrDefault();
            var exception = Record.Exception(() => record.GetAliasedValue<DateTime>("primarycontact", "fullname"));

            //Assert 
            Assert.NotNull(exception);
        }
    }
}
