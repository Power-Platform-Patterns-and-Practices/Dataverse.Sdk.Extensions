using Dataverse.Sdk.Extensions.Tests.EarlyBoundEntities;
using Dataverse.Sdk.Extensions.Tests.MetadataModels;
using FakeXrmEasy;
using FakeXrmEasy.Extensions;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Linq;
using Xunit;

namespace Dataverse.Sdk.Extensions.Tests
{

    public class IOrganizationServiceTests : FakeXrmEasyTestsBase
    {
        [Fact]
        public void Delete_Can_Delete_Record_By_EntityReference()
        {
            //Arrange
            var accountToDelete = new Entity("account")
            {
                Id = Guid.NewGuid(),
                ["name"] = "Your Company"
            };

            _context.Initialize(accountToDelete);

            //Act
            _service.Delete(accountToDelete.ToEntityReference());

            //Assert
            Assert.Empty(_context.CreateQuery("account"));
        }

        [Fact]
        public void Delete_Can_Delete_Record_By_Entity()
        {
            //Arrange
            var accountToDelete = new Entity("account")
            {
                Id = Guid.NewGuid(),
                ["name"] = "Your Company"
            };

            _context.Initialize(accountToDelete);

            //Act
            _service.Delete(accountToDelete);

            //Assert
            Assert.Empty(_context.CreateQuery("account"));
        }

        [Fact]
        public void Delete_Can_Delete_Record_By_Alternate_Key()
        {
            //Arrange
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
            _context.InitializeMetadata(metadata);
            _context.Initialize(accountToDelete);

            //Act
            _service.Delete("account", "name", accountToDelete.GetAttributeValue<string>("name"));

            //Assert
            Assert.Empty(_context.CreateQuery("account"));
        }

        [Fact]
        public void Delete_Can_Delete_EarlyBound_Record_By_Alternate_Key()
        {
            //Arrange
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
            _context.InitializeMetadata(metadata);
            _context.Initialize(accountToDelete);

            //Act
            _service.Delete<Account>(Account.Fields.Name, accountToDelete.Name);

            //Assert
            Assert.Empty(_context.CreateQuery<Account>());
        }

        [Fact]
        public void Delete_Can_Delete_Record_By_Alternate_Key_Multi()
        {
            //Arrange
            var accountToDelete = new Entity("account")
            {
                Id = Guid.NewGuid(),
                ["name"] = "Your Company",
                ["accountnumber"] = "1234567890"
            };
            var metadata = AccountMetadata.GetEntityMetadata();
            metadata.SetSealedPropertyValue(
                nameof(metadata.Keys),
                new EntityKeyMetadata[] {
                    new EntityKeyMetadata()
                    {
                        KeyAttributes = new string[] { "name", "accountnumber" }
                    }
                });
            _context.InitializeMetadata(metadata);
            _context.Initialize(accountToDelete);

            var keys = new KeyAttributeCollection
            {
                { "name", accountToDelete.GetAttributeValue<string>("name") },
                { "accountnumber", accountToDelete.GetAttributeValue<string>("accountnumber") }
            };


            //Act
            _service.Delete("account", keys);

            //Assert
            Assert.Empty(_context.CreateQuery("account"));
        }

        [Fact]
        public void Delete_Can_Delete_EarlyBound_Record_By_Alternate_Key_Multi()
        {
            //Arrange
            var accountToDelete = new Account()
            {
                Id = Guid.NewGuid(),
                Name = "Your Company",
                AccountNumber = "1234567890"
            };
            var metadata = AccountMetadata.GetEntityMetadata();
            metadata.SetSealedPropertyValue(
                nameof(metadata.Keys),
                new EntityKeyMetadata[] {
                    new EntityKeyMetadata()
                    {
                        KeyAttributes = new string[] { Account.Fields.Name, Account.Fields.AccountNumber }
                    }
                });
            _context.InitializeMetadata(metadata);
            _context.Initialize(accountToDelete);

            var keys = new KeyAttributeCollection
            {
                { Account.Fields.Name, accountToDelete.Name },
                { Account.Fields.AccountNumber, accountToDelete.AccountNumber }
            };

            //Act
            _service.Delete<Account>(keys);

            //Assert
            Assert.Empty(_context.CreateQuery<Account>());
        }

        [Fact]
        public void GetCurrentUserRoles_Returns_The_Current_User_Roles()
        {
            //Arrange
            var currentUserEntity = new Entity("systemuser")
            {
                Id = Guid.NewGuid()
            };
            var currentUser = currentUserEntity.ToEntityReference();
            _context.CallerId = currentUser;
            var sysAdmin = new Entity("role")
            {
                Id = Guid.NewGuid(),
                ["Name"] = "System Administrator",
            };
            var sysCustomizer = new Entity("role")
            {
                Id = Guid.NewGuid(),
                ["Name"] = "System Customizer",
            };
            var entities = new Entity[]
            {
                new Entity("systemuserroles")
                {
                    Id=Guid.NewGuid(),
                    ["roleid"] = sysCustomizer.ToEntityReference(),
                    ["systemuserid"] = currentUser
                },
                new Entity("systemuserroles")
                {
                    Id=Guid.NewGuid(),
                    ["roleid"] = sysAdmin.ToEntityReference(),
                    ["systemuserid"] = currentUser
                },
                new Entity("systemuserroles")
                {
                    Id=Guid.NewGuid(),
                    ["roleid"]=sysCustomizer.ToEntityReference(),
                    ["systemuserid"] = new EntityReference("systemuser", Guid.NewGuid())
                },
                sysAdmin,
                sysCustomizer,
                currentUserEntity
            };
            _context.Initialize(entities);

            //Act
            var roles = _service.GetCurrentUserRoles();

            //Assert
            Assert.Equal(2, roles.Count);
        }

        [Fact]
        public void GetCurrentUserRoles_Returns_Empty_If_No_Roles()
        {
            //Arrange
            var currentUserEntity = new Entity("systemuser")
            {
                Id = Guid.NewGuid()
            };
            var currentUser = currentUserEntity.ToEntityReference();
            _context.CallerId = currentUser;
            var sysAdmin = new Entity("role")
            {
                Id = Guid.NewGuid(),
                ["Name"] = "System Administrator",
            };
            var entities = new Entity[]
            {
                new Entity("systemuserroles")
                {
                    Id=Guid.NewGuid(),
                    ["roleid"]=sysAdmin.ToEntityReference(),
                    ["systemuserid"] = new EntityReference("systemuser", Guid.NewGuid())
                },
                sysAdmin,
                currentUserEntity
            };
            _context.Initialize(entities);

            //Act
            var roles = _service.GetCurrentUserRoles();

            //Assert
            Assert.Empty(roles);
        }

        [Fact]
        public void GetEnvironmentVariable_Throws_If_Variable_Does_Not_Exist()
        {
            //Arrange
            var fakedContext = new XrmFakedContext();

            //Act
            var exception = Record.Exception(() => fakedContext.GetOrganizationService().GetEnvironmentVariable("nonexistent"));

            //Assert
            Assert.NotNull(exception);
        }

        [Fact]
        public void GetEnvironmentVariable_Returns_Value_as_String()
        {
            //Arrange
            var environmentvariabledefinition = new Entity("environmentvariabledefinition")
            {
                Id = Guid.NewGuid(),
                ["schemaname"] = "environmentVariable"
            };
            var environmentvariablevalue = new Entity("environmentvariablevalue")
            {
                Id = Guid.NewGuid(),
                ["value"] = "Environment Variable",
                ["environmentvariabledefinitionid"] = environmentvariabledefinition.ToEntityReference()
            };
            _context.Initialize(new Entity[] { environmentvariabledefinition, environmentvariablevalue });

            //Act
            var value = _service.GetEnvironmentVariable("environmentVariable");

            //Assert
            Assert.Equal("Environment Variable", value);
        }

        [Fact]
        public void GetEnvironmentVariables_Returns_Values_as_Dictionary()
        {
            //Arrange
            var environmentvariabledefinition1 = new Entity("environmentvariabledefinition")
            {
                Id = Guid.NewGuid(),
                ["schemaname"] = "environmentVariable1"
            };
            var environmentvariablevalue1 = new Entity("environmentvariablevalue")
            {
                Id = Guid.NewGuid(),
                ["value"] = "First Environment Variable",
                ["environmentvariabledefinitionid"] = environmentvariabledefinition1.ToEntityReference()
            };
            var environmentvariabledefinition2 = new Entity("environmentvariabledefinition")
            {
                Id = Guid.NewGuid(),
                ["schemaname"] = "environmentVariable2"
            };
            var environmentvariablevalue2 = new Entity("environmentvariablevalue")
            {
                Id = Guid.NewGuid(),
                ["value"] = "Second Environment Variable",
                ["environmentvariabledefinitionid"] = environmentvariabledefinition2.ToEntityReference()
            };
            _context.Initialize(new Entity[] {
                environmentvariabledefinition1,
                environmentvariablevalue1,
                environmentvariabledefinition2,
                environmentvariablevalue2 });

            //Act
            var values = _service.GetEnvironmentVariables("environmentVariable1", "environmentVariable2");

            //Assert
            Assert.Equal(2, values.Count);
            Assert.True(values.ContainsKey("environmentVariable1"));
            Assert.Equal("First Environment Variable", values["environmentVariable1"]);
        }

        [Fact]
        public void GetEnvironmentVariables_Throws_If_No_Variables_Are_Found()
        {
            //Arrange
            
            //Act
            var exception = Record.Exception(() => _service.GetEnvironmentVariables("environmentVariable1", "environmentVariable2"));

            //Assert
            Assert.NotNull(exception);
        }

        [Fact]
        public void GetEnvironmentVariables_Throws_If_Not_All_Variables_Are_Found()
        {
            //Arrange
            var environmentvariabledefinition = new Entity("environmentvariabledefinition")
            {
                Id = Guid.NewGuid(),
                ["schemaname"] = "environmentVariable1"
            };
            var environmentvariablevalue = new Entity("environmentvariablevalue")
            {
                Id = Guid.NewGuid(),
                ["value"] = "Environment Variable",
                ["environmentvariabledefinitionid"] = environmentvariabledefinition.ToEntityReference()
            };
            _context.Initialize(new Entity[] { environmentvariabledefinition, environmentvariablevalue });

            //Act
            var exception = Record.Exception(() => _service.GetEnvironmentVariables("environmentVariable1", "environmentVariable2"));

            //Assert
            Assert.NotNull(exception);
        }

        [Fact]
        public void Upsert_Creates_Record_If_Not_Exists()
        {
            //Arrange
            _context.Initialize(new Entity("account")
            {
                Id = Guid.NewGuid(),
                ["name"] = "Another Company"
            });
            var account = new Entity("account")
            {
                Id = Guid.NewGuid(),
                ["name"] = "Your Company"
            };

            //Act
            var created = _service.Upsert(account);

            //Assert
            Assert.True(created);
            Assert.NotEmpty(_context.CreateQuery("account").Where(x => x.Id == account.Id));
        }

        [Fact]
        public void Upsert_Updates_Record_If_Exists()
        {
            //Arrange
            var account = new Entity("account")
            {
                Id = Guid.NewGuid(),
                ["name"] = "Your Company"
            };
            _context.Initialize(account);
            account["name"] = "Still Your Company";

            //Act
            var created = _service.Upsert(account);

            //Assert
            Assert.False(created);
            Assert.NotEmpty(_context.CreateQuery("account").Where(x => x.Id == account.Id));
            Assert.Equal("Still Your Company", _context.CreateQuery("account").First().GetAttributeValue<string>("name"));
        }
    }
}
