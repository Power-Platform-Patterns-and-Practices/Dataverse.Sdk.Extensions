using Dataverse.Sdk.Extensions.Tests.FakeMessageExecutors;
using Dataverse.Sdk.Extensions.Tests.MetadataModels;
using FakeXrmEasy;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Linq;
using Xunit;

namespace Dataverse.Sdk.Extensions.Tests
{
    public class EntityTests
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

        [Fact]
        public void GetAliasedValue_Retruns_Default_If_Empty()
        {
            //Arrange
            var record = new Entity("account");

            //Act
            var count = record.GetAliasedValue<int>("primarycontact", "debts");

            //Assert
            Assert.Equal(0, count);
        }

        [Fact]
        public void Clone_default_addCloneLabel_Adds_Clone_Label()
        {
            var fakedContext = new XrmFakedContext();
            var metadata = AccountMetadata.GetEntityMetadata();
            var entityMetadata = new EntityMetadataCollection() { metadata };
            fakedContext.AddFakeMessageExecutor<RetrieveMetadataChangesRequest>(new RetrieveMetadataChangesRequestExecutor(entityMetadata));

            var clone = new Entity("account") { ["name"] = "Your Company" }.Clone(fakedContext.GetOrganizationService());

            Assert.Equal("Your Company (clone)", clone.GetAttributeValue<string>("name"));
        }

        [Fact]
        public void Clone_addCloneLabel_false_Ignores_Clone_Label()
        {
            var fakedContext = new XrmFakedContext();
            var metadata = AccountMetadata.GetEntityMetadata();
            var entityMetadata = new EntityMetadataCollection() { metadata };
            fakedContext.AddFakeMessageExecutor<RetrieveMetadataChangesRequest>(new RetrieveMetadataChangesRequestExecutor(entityMetadata));

            var clone = new Entity("account") { ["name"] = "Your Company" }.Clone(fakedContext.GetOrganizationService(), false);

            Assert.Equal("Your Company", clone.GetAttributeValue<string>("name"));
        }

        [Fact]
        public void Clone_columnsToRemove_Ignores_Specified_Columns()
        {
            var fakedContext = new XrmFakedContext();
            var metadata = AccountMetadata.GetEntityMetadata();
            var entityMetadata = new EntityMetadataCollection() { metadata };
            fakedContext.AddFakeMessageExecutor<RetrieveMetadataChangesRequest>(new RetrieveMetadataChangesRequestExecutor(entityMetadata));

            var clone = new Entity("account") { ["name"] = "Your Company", ["primarycontactid"] = new EntityReference("contact", Guid.NewGuid()) }.Clone(fakedContext.GetOrganizationService(), true, "primarycontactid");

            Assert.Null(clone.GetAttributeValue<EntityReference>("primarycontactid"));
        }

        [Fact]
        public void Clone_Correctly_Clones_Record_Without_columnsToRemove()
        {
            var fakedContext = new XrmFakedContext();
            var metadata = AccountMetadata.GetEntityMetadata();
            var entityMetadata = new EntityMetadataCollection() { metadata };
            fakedContext.AddFakeMessageExecutor<RetrieveMetadataChangesRequest>(new RetrieveMetadataChangesRequestExecutor(entityMetadata));

            var clone = new Entity("account") {
                ["name"] = "Your Company",
                ["primarycontactid"] = new EntityReference("contact", Guid.NewGuid())
            }.Clone(fakedContext.GetOrganizationService());

            Assert.NotNull(clone.GetAttributeValue<EntityReference>("primarycontactid"));
        }

        [Fact]
        public void Clone_Ignores_Uniqueidentifier_Columns()
        {
            var fakedContext = new XrmFakedContext();
            var metadata = AccountMetadata.GetEntityMetadata();
            var entityMetadata = new EntityMetadataCollection() { metadata };
            fakedContext.AddFakeMessageExecutor<RetrieveMetadataChangesRequest>(new RetrieveMetadataChangesRequestExecutor(entityMetadata));

            var clone = new Entity("account")
            {
                ["name"] = "Your Company",
                ["processid"] = Guid.NewGuid()
            }.Clone(fakedContext.GetOrganizationService());

            Assert.Null(clone.GetAttributeValue<Guid?>("processid"));
        }
    }
}
