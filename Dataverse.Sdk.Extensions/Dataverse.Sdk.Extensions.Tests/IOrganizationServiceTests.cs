using Dataverse.Sdk.Extensions.Tests.EarlyBoundEntities;
using Dataverse.Sdk.Extensions.Tests.MetadataModels;
using FakeXrmEasy;
using FakeXrmEasy.Extensions;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using Xunit;

namespace Dataverse.Sdk.Extensions.Tests
{
    public class IOrganizationServiceTests
    {
        [Fact]
        public void Delete_Can_Delete_Record_By_Alternate_Key()
        {
            //Arrange
            var fakedContext = new XrmFakedContext();
            var accountToDelete = new Entity("account")
            {
                Id = Guid.NewGuid(),
                ["name"] = "Your Company"
            };
            var metadata = AccountMetadata.GetEntityMetadata();
            metadata.SetSealedPropertyValue(
                nameof(metadata.Keys), 
                new EntityKeyMetadata[] {
                    new EntityKeyMetadata()
                    {
                        KeyAttributes = new string[] { "name" }
                    }
                });
            fakedContext.InitializeMetadata(metadata);
            fakedContext.Initialize(accountToDelete);

            //Act
            fakedContext.GetOrganizationService().Delete("account", "name", accountToDelete.GetAttributeValue<string>("name"));

            //Assert
            Assert.Empty(fakedContext.CreateQuery("account"));
        }

        [Fact]
        public void Delete_Can_Delete_EarlyBound_Record_By_Alternate_Key()
        {
            //Arrange
            var fakedContext = new XrmFakedContext();
            var accountToDelete = new Account()
            {
                Id = Guid.NewGuid(),
                Name = "Your Company"
            };
            var metadata = AccountMetadata.GetEntityMetadata();
            metadata.SetSealedPropertyValue(
                nameof(metadata.Keys),
                new EntityKeyMetadata[] {
                    new EntityKeyMetadata()
                    {
                        KeyAttributes = new string[] { Account.Fields.Name }
                    }
                });
            fakedContext.InitializeMetadata(metadata);
            fakedContext.Initialize(accountToDelete);

            //Act
            fakedContext.GetOrganizationService().Delete<Account>(Account.Fields.Name, accountToDelete.Name);

            //Assert
            Assert.Empty(fakedContext.CreateQuery<Account>());
        }
    }
}
