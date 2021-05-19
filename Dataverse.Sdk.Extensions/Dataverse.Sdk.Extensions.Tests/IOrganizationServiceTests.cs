using Dataverse.Sdk.Extensions.Tests.EarlyBoundEntities;
using Dataverse.Sdk.Extensions.Tests.MetadataModels;
using FakeXrmEasy;
using FakeXrmEasy.Extensions;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Dataverse.Sdk.Extensions.Tests
{

    public class IOrganizationServiceTests : FakeXrmEasyTestsBase
    {
        [Fact]
        public void CreateFromInitialization_Creates_Another_Row_Using_Standard_Columns()
        {
            //Arrange
            var current = new Entity("account")
            {
                Id = Guid.NewGuid(),
                ["name"] = "Your Company",
                ["description"] = "Will not be used"
            };
            var entityMap = new Entity("entitymap")
            {
                Id = Guid.NewGuid(),
                ["sourceentityname"] = "account",
                ["targetentityname"] = "account"
            };
            var attributeMap = new Entity("attributemap")
            {
                Id = Guid.NewGuid(),
                ["entitymapid"] = entityMap.ToEntityReference(),
                ["sourceattributename"] = "name",
                ["targetattributename"] = "name"
            };
            _context.Initialize(new Entity[] { current, entityMap, attributeMap });

            //Act
            var created = _service.CreateFromInitialization("account", current.ToEntityReference(), TargetFieldType.All);

            //Assert
            Assert.NotEqual(current.Id, created.Id);
            Assert.Equal(current.GetAttributeValue<string>("name"), created.GetAttributeValue<string>("name"));
            Assert.Null(created.GetAttributeValue<string>("description"));
        }

        [Fact]
        public void CreateFromInitialization_Creates_Another_Row_Using_Additional_Columns()
        {
            //Arrange
            var current = new Entity("account")
            {
                Id = Guid.NewGuid(),
                ["name"] = "Your Company",
                ["description"] = "Will not be used"
            };
            var entityMap = new Entity("entitymap")
            {
                Id = Guid.NewGuid(),
                ["sourceentityname"] = "account",
                ["targetentityname"] = "account"
            };
            var attributeMap = new Entity("attributemap")
            {
                Id = Guid.NewGuid(),
                ["entitymapid"] = entityMap.ToEntityReference(),
                ["sourceattributename"] = "name",
                ["targetattributename"] = "name"
            };
            _context.Initialize(new Entity[] { current, entityMap, attributeMap });

            //Act
            var created = _service.CreateFromInitialization(
                                "account",
                                current.ToEntityReference(),
                                TargetFieldType.All,
                                new Dictionary<string, object> { { "description", "New Description" } }
                            );

            //Assert
            Assert.NotEqual(current.Id, created.Id);
            Assert.Equal(current.GetAttributeValue<string>("name"), created.GetAttributeValue<string>("name"));
            Assert.Equal("New Description", created.GetAttributeValue<string>("description"));
        }

        [Fact]
        public void CreateFromInitialization_Creates_Another_Earlybound_Row_Using_Additional_Columns()
        {
            //Arrange
            var current = new Account()
            {
                Id = Guid.NewGuid(),
                Name = "Your Company",
                Description = "Will not be used"
            };
            var entityMap = new EntityMap()
            {
                Id = Guid.NewGuid(),
                SourceEntityName = "account",
                TargetEntityName = "account"
            };
            var attributeMap = new AttributeMap()
            {
                Id = Guid.NewGuid(),
                EntityMapId = entityMap.ToEntityReference(),
                SourceAttributeName = "name",
                TargetAttributeName = "name"
            };
            _context.Initialize(new Entity[] { current, entityMap, attributeMap });

            //Act
            var created = _service.CreateFromInitialization<Account>(
                                current.ToEntityReference(),
                                TargetFieldType.All,
                                new Dictionary<string, object> { { "description", "New Description" } }
                            );

            //Assert
            Assert.NotEqual(current.Id, created.Id);
            Assert.Equal(current.Name, created.Name);
            Assert.Equal("New Description", created.Description);
        }

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

        [Fact]
        public void RetrieveSingleTyped()
        {
            //Arrange
            var id = Guid.NewGuid();
            var account = new Account()
            {
                Id = id,
                Name = "Testing Account"
            };

            _context.Initialize(account);

            //Act
            Account retrievedAccount = _service.Retrieve<Account>(id, new Microsoft.Xrm.Sdk.Query.ColumnSet(Account.Fields.Name));

            //Assert
            Assert.Equal(account.Name, retrievedAccount.Name);
        }

        [Fact]
        public void RetrieveMultipleTyped()
        {
            //Arrange
            string distinctAccountName = Guid.NewGuid().ToString();

            List<Entity> accounts = new List<Entity>();
            for (int i = 0; i < 5; i++)
            {
                accounts.Add(new Account()
                {
                    Id = Guid.NewGuid(),
                    Name = distinctAccountName
                });
            }
            _context.Initialize(accounts);

            //Act
            Microsoft.Xrm.Sdk.Query.QueryExpression queryExpression = new Microsoft.Xrm.Sdk.Query.QueryExpression(Account.EntityLogicalName)
            {
                ColumnSet = new Microsoft.Xrm.Sdk.Query.ColumnSet(Account.Fields.Name)
            };
            queryExpression.Criteria.AddCondition(Account.Fields.Name, Microsoft.Xrm.Sdk.Query.ConditionOperator.Equal, distinctAccountName);

            List<Account> retrievedAccounts = _service.RetrieveMultiple<Account>(queryExpression);

            //Assert
            Assert.Equal(5, retrievedAccounts.Count());
        }

        [Fact]
        public void RetrieveAll_QueryExpression()
        {
            //Arrange
            int totalRecords = 5010;
            string distinctAccountName = Guid.NewGuid().ToString();

            List<Entity> accounts = new List<Entity>();
            for (int i = 0; i < totalRecords; i++)
            {
                accounts.Add(new Account()
                {
                    Id = Guid.NewGuid(),
                    Name = distinctAccountName
                });
            }
            _context.Initialize(accounts);

            //Act
            Microsoft.Xrm.Sdk.Query.QueryExpression queryExpression = new Microsoft.Xrm.Sdk.Query.QueryExpression(Account.EntityLogicalName)
            {
                ColumnSet = new Microsoft.Xrm.Sdk.Query.ColumnSet(Account.Fields.Name)
            };
            queryExpression.Criteria.AddCondition(Account.Fields.Name, Microsoft.Xrm.Sdk.Query.ConditionOperator.Equal, distinctAccountName);

            IEnumerable<Entity> results = _service.RetrieveAll(queryExpression);

            //Assert
            Assert.Equal(totalRecords, results.Count());
        }

        [Fact]
        public void RetrieveAll_QueryExpression_Typed()
        {
            //Arrange
            int totalRecords = 5010;
            string distinctAccountName = Guid.NewGuid().ToString();

            List<Entity> accounts = new List<Entity>();
            for (int i = 0; i < totalRecords; i++)
            {
                accounts.Add(new Account()
                {
                    Id = Guid.NewGuid(),
                    Name = distinctAccountName
                });
            }
            _context.Initialize(accounts);

            //Act
            Microsoft.Xrm.Sdk.Query.QueryExpression queryExpression = new Microsoft.Xrm.Sdk.Query.QueryExpression(Account.EntityLogicalName)
            {
                ColumnSet = new Microsoft.Xrm.Sdk.Query.ColumnSet(Account.Fields.Name)
            };
            queryExpression.Criteria.AddCondition(Account.Fields.Name, Microsoft.Xrm.Sdk.Query.ConditionOperator.Equal, distinctAccountName);

            IEnumerable<Account> results = _service.RetrieveAll<Account>(queryExpression);

            //Assert
            Assert.Equal(totalRecords, results.Count());
        }

        [Fact]
        public void RetrieveAll_QueryByAttribute()
        {
            //Arrange
            int totalRecords = 5010;
            string distinctAccountName = Guid.NewGuid().ToString();

            List<Entity> accounts = new List<Entity>();
            for (int i = 0; i < totalRecords; i++)
            {
                accounts.Add(new Account()
                {
                    Id = Guid.NewGuid(),
                    Name = distinctAccountName
                });
            }
            _context.Initialize(accounts);

            //Act
            QueryByAttribute queryByAttribute = new QueryByAttribute(Account.EntityLogicalName);
            queryByAttribute.AddAttributeValue(Account.Fields.Name, distinctAccountName);
            queryByAttribute.ColumnSet = new ColumnSet(Account.Fields.Name);

            IEnumerable<Entity> results = _service.RetrieveAll(queryByAttribute);

            //Assert
            Assert.Equal(totalRecords, results.Count());
        }

        [Fact]
        public void RetrieveAll_QueryByAttribute_Typed()
        {
            //Arrange
            int totalRecords = 5010;
            string distinctAccountName = Guid.NewGuid().ToString();

            List<Entity> accounts = new List<Entity>();
            for (int i = 0; i < totalRecords; i++)
            {
                accounts.Add(new Account()
                {
                    Id = Guid.NewGuid(),
                    Name = distinctAccountName
                });
            }
            _context.Initialize(accounts);

            //Act
            QueryByAttribute queryByAttribute = new QueryByAttribute(Account.EntityLogicalName);
            queryByAttribute.AddAttributeValue(Account.Fields.Name, distinctAccountName);
            queryByAttribute.ColumnSet = new ColumnSet(Account.Fields.Name);

            IEnumerable<Account> results = _service.RetrieveAll<Account>(queryByAttribute);

            //Assert
            Assert.Equal(totalRecords, results.Count());
        }

        [Fact]
        public void RetrieveAll_FetchExpression()
        {
            //Arrange
            int totalRecords = 5010;
            string distinctAccountName = Guid.NewGuid().ToString();

            List<Entity> accounts = new List<Entity>();
            for (int i = 0; i < totalRecords; i++)
            {
                accounts.Add(new Account()
                {
                    Id = Guid.NewGuid(),
                    Name = distinctAccountName
                });
            }
            _context.Initialize(accounts);

            //Act
            var fetchXml = $@"
                <fetch>
                  <entity name='account'>
                    <attribute name='name' />
                  </entity>
                </fetch>";
            FetchExpression fe = new FetchExpression(fetchXml);

            IEnumerable<Entity> results = _service.RetrieveAll(fe);

            //Assert
            Assert.Equal(totalRecords, results.Count());
        }

        [Fact]
        public void RetrieveAll_FetchExpression_Typed()
        {
            //Arrange
            int totalRecords = 5010;
            string distinctAccountName = Guid.NewGuid().ToString();

            List<Entity> accounts = new List<Entity>();
            for (int i = 0; i < totalRecords; i++)
            {
                accounts.Add(new Account()
                {
                    Id = Guid.NewGuid(),
                    Name = distinctAccountName
                });
            }
            _context.Initialize(accounts);

            //Act
            var fetchXml = $@"
                <fetch>
                  <entity name='account'>
                    <attribute name='name' />
                  </entity>
                </fetch>";
            FetchExpression fe = new FetchExpression(fetchXml);

            IEnumerable<Account> results = _service.RetrieveAll<Account>(fe);

            //Assert
            Assert.Equal(totalRecords, results.Count());
        }
    }
}
