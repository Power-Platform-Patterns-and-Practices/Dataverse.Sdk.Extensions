using Dataverse.Sdk.Extensions.Tests.EarlyBoundEntities;
using System;
using Xunit;

namespace Dataverse.Sdk.Extensions.Tests
{
    public class SystemTypesTests
    {
        [Fact]
        public void ToEntityReference_Can_Convert_Guid_To_EntityReference()
        {
            //Arrange
            var entity = "account";
            var guid = Guid.NewGuid();

            //Act
            var entityReference = guid.ToEntityReference(entity);

            //Assert
            Assert.Equal(entity, entityReference.LogicalName);
            Assert.Equal(guid, entityReference.Id);
        }

        [Fact]
        public void ToEntityReference_Can_Convert_Guid_To_EarlyBound_EntityReference()
        {
            //Arrange
            var guid = Guid.NewGuid();

            //Act
            var entityReference = guid.ToEntityReference<Account>();

            //Assert
            Assert.Equal(Account.EntityLogicalName, entityReference.LogicalName);
            Assert.Equal(guid, entityReference.Id);
        }
    }
}
