using Microsoft.Xrm.Sdk;
using System;
using Xunit;

namespace Dataverse.Sdk.Extensions.Tests
{
    public class EntityReferenceTests
    {
        [Fact]
        public void GetNameId_Can_Display_Name_And_Id()
        {
            // Arrange
            var nullValue = (EntityReference) null;
            var empty = new EntityReference();
            var idOnly = new EntityReference("account", Guid.NewGuid());
            var full = new EntityReference("account", Guid.NewGuid())
            {
                Name = "Bart Simpson"
            };

            //Assert 
            Assert.Equal("null", nullValue.GetNameId());
            Assert.Equal(Guid.Empty.ToString(), empty.GetNameId());
            Assert.Equal(idOnly.Id.ToString(), idOnly.GetNameId());
            Assert.Equal($"{full.Name} ({full.Id})", full.GetNameId());
            Assert.Equal($"{full.Name} {full.Id}", full.GetNameId("{0} {1}"));
        }
    }
}
