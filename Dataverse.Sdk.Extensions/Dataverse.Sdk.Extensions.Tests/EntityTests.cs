using Dataverse.Sdk.Extensions.Tests.FakeMessageExecutors;
using Dataverse.Sdk.Extensions.Tests.MetadataModels;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Linq;
using Xunit;

namespace Dataverse.Sdk.Extensions.Tests
{
    public class EntityTests : FakeXrmEasyTestsBase
    {
        [Fact]
        public void Add_Parties_Without_party_Throws_Exception()
        {
            var email = new Entity("email");
            var exception = Record.Exception(() => email.AddParties("to"));

            //Assert
            Assert.NotNull(exception);
        }

        [Fact]
        public void Add_Party_Can_Read_Party_From_Record()
        {
            var id = Guid.NewGuid();
            var contactReference = new EntityReference("contact", id);

            var email = new Entity("email");
            email.AddParty("to", contactReference);

            Assert.Equal(id, email.GetAttributeValue<EntityCollection>("to").Entities.First().GetAttributeValue<EntityReference>("partyid").Id);
        }

        [Fact]
        public void Add_Two_Parties_Can_Read_Tow_Parties_From_Record()
        {
            var id = Guid.NewGuid();
            var id2 = Guid.NewGuid();
            var contactReference = new EntityReference("contact", id);
            var contactReference2 = new EntityReference("contact", id2);

            var email = new Entity("email");
            email.AddParties("to", contactReference, contactReference2);

            Assert.Equal(2, email.GetAttributeValue<EntityCollection>("to").Entities.Count);
        }

        [Fact]
        public void Clone_addCloneLabel_false_Ignores_Clone_Label()
        {
            var metadata = AccountMetadata.GetEntityMetadata();
            var entityMetadata = new EntityMetadataCollection() { metadata };
            _context.AddFakeMessageExecutor<RetrieveMetadataChangesRequest>(new RetrieveMetadataChangesRequestExecutor(entityMetadata));

            var clone = new Entity("account")
            {
                ["name"] = "Your Company"
            }.Clone(_service, false);

            Assert.Equal("Your Company", clone.GetAttributeValue<string>("name"));
        }

        [Fact]
        public void Clone_columnsToRemove_Ignores_Specified_Columns()
        {
            var metadata = AccountMetadata.GetEntityMetadata();
            var entityMetadata = new EntityMetadataCollection() { metadata };
            _context.AddFakeMessageExecutor<RetrieveMetadataChangesRequest>(new RetrieveMetadataChangesRequestExecutor(entityMetadata));

            var clone = new Entity("account")
            {
                ["name"] = "Your Company",
                ["primarycontactid"] = new EntityReference("contact", Guid.NewGuid())
            }.Clone(_service, true, "primarycontactid");

            Assert.Null(clone.GetAttributeValue<EntityReference>("primarycontactid"));
        }

        [Fact]
        public void Clone_Correctly_Clones_Record_Without_columnsToRemove()
        {
            var metadata = AccountMetadata.GetEntityMetadata();
            var entityMetadata = new EntityMetadataCollection() { metadata };
            _context.AddFakeMessageExecutor<RetrieveMetadataChangesRequest>(new RetrieveMetadataChangesRequestExecutor(entityMetadata));

            var clone = new Entity("account")
            {
                ["name"] = "Your Company",
                ["primarycontactid"] = new EntityReference("contact", Guid.NewGuid())
            }.Clone(_service);

            Assert.NotNull(clone.GetAttributeValue<EntityReference>("primarycontactid"));
        }

        [Fact]
        public void Clone_default_addCloneLabel_Adds_Clone_Label()
        {
            var metadata = AccountMetadata.GetEntityMetadata();
            var entityMetadata = new EntityMetadataCollection() { metadata };
            _context.AddFakeMessageExecutor<RetrieveMetadataChangesRequest>(new RetrieveMetadataChangesRequestExecutor(entityMetadata));

            var clone = new Entity("account") { ["name"] = "Your Company" }.Clone(_service);

            Assert.Equal("Your Company (clone)", clone.GetAttributeValue<string>("name"));
        }

        [Fact]
        public void Clone_Ignores_Uniqueidentifier_Columns()
        {
            var metadata = AccountMetadata.GetEntityMetadata();
            var entityMetadata = new EntityMetadataCollection() { metadata };
            _context.AddFakeMessageExecutor<RetrieveMetadataChangesRequest>(new RetrieveMetadataChangesRequestExecutor(entityMetadata));

            var clone = new Entity("account")
            {
                ["name"] = "Your Company",
                ["processid"] = Guid.NewGuid()
            }.Clone(_service);

            Assert.Null(clone.GetAttributeValue<Guid?>("processid"));
        }

        [Fact]
        public void GetAliasedValue_Can_Read_Aliased_Value_From_Record()
        {
            // Arrange
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
            _context.Initialize(new Entity[] { contact, account });

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

            Entity record = _service.RetrieveMultiple(query).Entities.FirstOrDefault();
            string fullname = record.GetAliasedValue<string>("primarycontact", "fullname");

            //Assert
            Assert.Equal(contact.GetAttributeValue<string>("fullname"), fullname);
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
        public void GetAliasedValue_Throws_If_Wrong_Aliased_Type()
        {
            // Arrange
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
            _context.Initialize(new Entity[] { contact, account });

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

            Entity record = _service.RetrieveMultiple(query).Entities.FirstOrDefault();
            var exception = Record.Exception(() => record.GetAliasedValue<DateTime>("primarycontact", "fullname"));

            //Assert
            Assert.NotNull(exception);
        }

        [Fact]
        public void Set_Parties_When_Parties_Contains_Record_Can_Read_Two_Parties_From_Record()
        {
            var id = Guid.NewGuid();
            var id2 = Guid.NewGuid();
            var id3 = Guid.NewGuid();
            var id4 = Guid.NewGuid();
            var contactReference = new EntityReference("contact", id);
            var contactReference2 = new EntityReference("contact", id2);
            var contactReference3 = new EntityReference("contact", id3);
            var contactReference4 = new EntityReference("contact", id4);

            var email = new Entity("email");
            email.AddParties("to", contactReference, contactReference2);
            email.SetParties("to", contactReference3, contactReference4);

            Assert.Equal(2, email.GetAttributeValue<EntityCollection>("to").Entities.Count);
        }

        [Fact]
        public void Set_Parties_Without_party_Throws_Exception()
        {
            var email = new Entity("email");
            var exception = Record.Exception(() => email.SetParties("to"));

            //Assert
            Assert.NotNull(exception);
        }

        [Fact]
        public void Set_Party_When_Parties_Contains_Record_Can_Read_One_Party_From_Record()
        {
            var id = Guid.NewGuid();
            var id2 = Guid.NewGuid();
            var id3 = Guid.NewGuid();
            var contactReference = new EntityReference("contact", id);
            var contactReference2 = new EntityReference("contact", id2);
            var contactReference3 = new EntityReference("contact", id3);

            var email = new Entity("email");
            email.AddParty("to", contactReference);
            email.AddParty("to", contactReference2);
            email.SetParty("to", contactReference3);

            Assert.Single(email.GetAttributeValue<EntityCollection>("to").Entities);
            Assert.Equal(id3, email.GetAttributeValue<EntityCollection>("to").Entities.First().GetAttributeValue<EntityReference>("partyid").Id);
        }
    }
}