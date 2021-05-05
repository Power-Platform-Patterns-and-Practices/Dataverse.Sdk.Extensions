using System;
using System.Collections.Generic;
using Dataverse.Sdk.Extensions.Tests.EarlyBoundEntities;
using Microsoft.Xrm.Sdk;
using Xunit;

namespace Dataverse.Sdk.Extensions.Tests
{
    public class ToStringDebugTests
    {
        private void AssertAreEqualHandleSpaces(string expected, string actual, int tabSpaces = 2)
        {
            var space = new string(new []{ (char)160 }); // This is not a space, it is a Non-Breaking Space (alt+255).  In the log things get trimmed, and this will prevent that from happening;
            expected = expected.Replace("\t", new string(' ', tabSpaces)).Replace("\r\n", "\n"); // The AppVeyor environment runs on Unix based environment, so this changes to handle new-line discrepancies.
            actual = actual.Replace(space, " ").Replace("\r\n", "\n");
            
            if (!expected.Equals(actual))
            {
                for (var i = 0; i < expected.Length && i < actual.Length; i++)
                {
                    if (expected[i] != actual[i])
                    {
                        Assert.Equal(expected, actual);
                    }
                }
            }

            AssertAreSameLength(expected, actual);

            Assert.Equal(expected, actual);

        }

        private static void AssertAreSameLength(string expected, string actual)
        {
            if (expected.Length == actual.Length)
            {
                return;
            }

            var info = expected.Length < actual.Length
                ? new { Shorter = expected, ShorterName = "Expected", Longer = actual, LongerName = "Actual" }
                : new { Shorter = actual, ShorterName = "Actual", Longer = expected, LongerName = "Expected" };

            var longer = info.Longer.Substring(0, info.Shorter.Length);
            if (longer == info.Shorter)
            {
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void Entity_Should_Show_Attributes()
        {
            // Arrange
            var account = new Account
            {
                Name = "MyName",
                AccountNumber = "XYZ",
                AccountCategoryCode = new OptionSetValue(1),
                ParentAccountId = new EntityReference("account", Guid.NewGuid()),
                Address1_Longitude = 123d,
                CreditLimit = new Money(10m)
            };

            // Act
            var sut = account.ToStringDebug();

            // Assert
            Assert.Equal(
$@"{{
  Id: ""00000000-0000-0000-0000-000000000000"",
  LogicalName: ""account"",
  accountcategorycode: 1,
  accountnumber: ""XYZ"",
  address1_longitude: 123,
  creditlimit: 10,
  name: ""MyName"",
  parentaccountid: {{LogicalName: ""account"", Id: ""{account.ParentAccountId.Id}""}}
}}",sut);
        }


        [Fact]
        public void EntityImageCollection_Should_Show_Images()
        {
            var entity1 = new Contact { Id = Guid.NewGuid(), LastName = "Doe" };
            var sut = new EntityImageCollection
            {
                { "PreImage1", entity1 }
            };

            AssertAreEqualHandleSpaces($@"PreImage_{entity1.LogicalName}_{entity1.Id:N}: {{
  contactid: ""{entity1.Id}"",
  lastname: ""Doe""
}}", sut.ToStringDebug("PreImage"));


            var entity2 = new Contact { Id = Guid.NewGuid(), FirstName = "John" };
            sut.Add("PreImage2", entity2);

            AssertAreEqualHandleSpaces($@"PreImage: {{
PreImage1: {{
  Id: ""{entity1.Id}"",
  LogicalName: ""contact"",
  contactid: ""{entity1.Id}"",
  lastname: ""Doe""
}},
PreImage2: {{
  Id: ""{entity2.Id}"",
  LogicalName: ""contact"",
  contactid: ""{entity2.Id}"",
  firstname: ""John""
}}
}}", sut.ToStringDebug("PreImage"));


        }

        [Fact]
        public void EntityReference_Should_Show_Values()
        {
            var sut = new EntityReference
            {
                Id = Guid.NewGuid(),
                LogicalName = Lead.EntityLogicalName
            };

            Assert.Equal($"{{LogicalName: \"{sut.LogicalName}\", Id: \"{sut.Id}\"}}", sut.ToStringDebug());

            sut.Name = "Test";
            Assert.Equal($"{{Name: \"{sut.Name}\", LogicalName: \"{sut.LogicalName}\", Id: \"{sut.Id}\"}}", sut.ToStringDebug());
        }

        #region Entity.ToStringAttributes

        [Fact]
        public void Entity_Should_Handle_Bool()
        {
            var sut = new Contact
            {
                CreditOnHold = true,
                DoNotBulkEMail = false,
                DoNotEMail = null
            };
            AssertAreEqualHandleSpaces($@"{{
  creditonhold: {sut.CreditOnHold.ToString().ToLower()},
  donotbulkemail: {sut.DoNotBulkEMail.ToString().ToLower()},
  donotemail: null
}}", sut.ToStringAttributes());
        }

        [Fact]
        public void Entity_Should_Handle_ByteArray()
        {
            var sut = new Contact
            {
                EntityImage = new byte[] { 0, 2, 1 }
            };
            AssertAreEqualHandleSpaces($@"{{
  entityimage: {{length: 3}}
}}", sut.ToStringAttributes());
        }

        [Fact]
        public void Entity_Should_Handle_Date()
        {
            var sut = new Contact
            {
                Anniversary = DateTime.UtcNow,
                BirthDate = DateTime.UtcNow.AddDays(-1d),
                OverriddenCreatedOn = null
            };
            AssertAreEqualHandleSpaces($@"{{
  anniversary: ""{sut.Anniversary}"",
  birthdate: ""{sut.BirthDate}"",
  overriddencreatedon: null
}}", sut.ToStringAttributes());
        }

        [Fact]
        public void Entity_Should_Handle_Double()
        {
            var sut = new Contact
            {
                Address1_Latitude = 1.1,
                Address1_Longitude = 2.12,
                Address2_Latitude = null
            };
            AssertAreEqualHandleSpaces($@"{{
  address1_latitude: {sut.Address1_Latitude},
  address1_longitude: {sut.Address1_Longitude},
  address2_latitude: null
}}", sut.ToStringAttributes());
        }

        [Fact]
        public void Entity_Should_Handle_EntityRef()
        {
            var sut = new Contact
            {
                ParentCustomerId = new EntityReference(Account.EntityLogicalName, Guid.NewGuid()),
                CreatedBy = new EntityReference("systemuser",Guid.NewGuid())
                {
                    Name = "John Doe"
                }
            };
            AssertAreEqualHandleSpaces($@"{{
  createdby: {{Name: ""{sut.CreatedBy.Name}"", LogicalName: ""systemuser"", Id: ""{sut.CreatedBy.Id}""}},
  parentcustomerid: {{LogicalName: ""account"", Id: ""{sut.ParentCustomerId.Id}""}}
}}", sut.ToStringAttributes());
        }

        [Fact]
        public void Entity_Should_Handle_Guid()
        {
            var sut = new Contact
            {
                Id = Guid.NewGuid()
            };
            AssertAreEqualHandleSpaces($@"{{
  contactid: ""{sut.Id}""
}}", sut.ToStringAttributes());
        }


        [Fact]
        public void Entity_Should_Handle_Int()
        {
            var sut = new Contact
            {
                Address1_UTCOffset = 1,
                Address2_UTCOffset = -1,
                Address3_UTCOffset = null
            };
            AssertAreEqualHandleSpaces($@"{{
  address1_utcoffset: {sut.Address1_UTCOffset},
  address2_utcoffset: {sut.Address2_UTCOffset},
  address3_utcoffset: null
}}", sut.ToStringAttributes());
        }

        [Fact]
        public void Entity_Should_Handle_Money()
        {
            var sut = new Contact
            {
                AccountRoleCode = null,
                AnnualIncome = new Money(10m),
                CreditLimit = new Money(400m)
            };
            AssertAreEqualHandleSpaces($@"{{
  accountrolecode: null,
  annualincome: {sut.AnnualIncome.Value},
  creditlimit: {sut.CreditLimit.Value}
}}", sut.ToStringAttributes());
        }


        [Fact]
        public void Entity_Should_Handle_Osv()
        {
            var sut = new Contact
            {
                Address1_AddressTypeCode = new OptionSetValue(1),
                AccountRoleCode = new OptionSetValue(2),
                Address1_FreightTermsCode = null
            };
            AssertAreEqualHandleSpaces($@"{{
  accountrolecode: {sut.AccountRoleCode.Value},
  address1_addresstypecode: {sut.Address1_AddressTypeCode.Value},
  address1_freighttermscode: null
}}", sut.ToStringAttributes());
        }

        [Fact]
        public void Entity_Should_Handle_String()
        {
            var sut = new Contact
            {
                FirstName = "In",
                LastName = "Dent"
            };
            AssertAreEqualHandleSpaces(@"{
  firstname: ""In"",
  lastname: ""Dent""
}", sut.ToStringAttributes());
        }

        #endregion Entity.ToStringAttributes

        [Fact]
        public void ParameterCollection_Should_Display_Values()
        {
            var now = DateTime.UtcNow;
            var ids = new List<Guid>
            {
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid()
            };
            var sut = new ParameterCollection
            {
                {"EntityRef", new EntityReference(Lead.EntityLogicalName, ids[0])},
                {
                    "EntityRefCollection", new EntityReferenceCollection(new List<EntityReference>
                    {
                        new EntityReference(Lead.EntityLogicalName, ids[1]),
                        new EntityReference(Contact.EntityLogicalName, ids[2]),
                        new EntityReference(Account.EntityLogicalName, ids[3])
                    })
                },
                {"IEnumerable", new List<string> {"v1", "v2", "v3"}},
                {
                    "EntityCollection", new EntityCollection(new List<Entity>
                    {
                        new Lead {Id = ids[4], FirstName = "Great"},
                        new Contact {Id = ids[5], LastName = "Good"}
                    })
                },
                {"OSV", new OptionSetValue(1)},
                {"Entity", new Contact {ManagerName = "Owner", BirthDate = now}},
                {
                    "Dict", new Dictionary<string, string>
                    {
                        {"Key1", "Value1"},
                        {"Key2", "Value2"}
                    }
                }
            };

            AssertAreEqualHandleSpaces($@"InputParameters: {{
  Dict: {{
    Key1: ""Value1"",
    Key2: ""Value2""
  }},
  Entity: {{
    birthdate: ""{now}"",
    managername: ""Owner""
  }},
  EntityCollection: [
    {{
      firstname: ""Great"",
      leadid: ""{ids[4]}""
    }},
    {{
      contactid: ""{ids[5]}"",
      lastname: ""Good""
    }}
  ],
  EntityRef: {{LogicalName: ""lead"", Id: ""{ids[0]}""}},
  EntityRefCollection: [
    {{LogicalName: ""lead"", Id: ""{ids[1]}""}},
    {{LogicalName: ""contact"", Id: ""{ids[2]}""}},
    {{LogicalName: ""account"", Id: ""{ids[3]}""}}
  ],
  IEnumerable: {{
    ""List`1"": [
      ""v1"",
      ""v2"",
      ""v3""
    ]
  }},
  OSV: 1
}}", sut.ToStringDebug("InputParameters"));

        }

        [Fact]
        public void ParameterCollection_Should_Display_Parameters()
        {
            // Entities only collections should not indent.
            var contact = new Contact
            {
                Id = Guid.NewGuid(),
                AccountRoleCode = new OptionSetValue(1)
            };
            var sut = new ParameterCollection
            {
                {"Target", contact}
            };
            AssertAreEqualHandleSpaces($@"InputParameters: {{
Target: {{
  accountrolecode: 1,
  contactid: ""{contact.Id}""
}}
}}", sut.ToStringDebug("InputParameters"));
        }
    }
}
