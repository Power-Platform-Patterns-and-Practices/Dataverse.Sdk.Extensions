using Microsoft.Xrm.Sdk.Metadata;
using FakeXrmEasy.Extensions;
using System.Linq;

namespace Dataverse.Sdk.Extensions.Tests.MetadataModels
{
    class AccountMetadata
    {
        public static EntityMetadata GetEntityMetadata()
        {
            var metadata = new EntityMetadata
            {
                LogicalName = "account"
            };
            metadata.SetSealedPropertyValue(nameof(metadata.PrimaryIdAttribute), "accountid");
            metadata.SetSealedPropertyValue(nameof(metadata.PrimaryNameAttribute), "name");

            var accountid = new UniqueIdentifierAttributeMetadata("accountid")
            {
                LogicalName = "accountid"
            };
            accountid.SetSealedPropertyValue(nameof(accountid.IsPrimaryId), true);
            accountid.SetSealedPropertyValue(nameof(accountid.IsValidForCreate), true);

            var name = new StringAttributeMetadata("name")
            {
                LogicalName = "name"
            };
            name.SetSealedPropertyValue(nameof(name.IsPrimaryName), true);
            name.SetSealedPropertyValue(nameof(name.IsValidForCreate), true);

            var primarycontactid = new LookupAttributeMetadata()
            {
                LogicalName = "primarycontactid",
                SchemaName = "primarycontactid"
            };
            primarycontactid.SetSealedPropertyValue(nameof(primarycontactid.IsValidForCreate), true);

            metadata.SetAttributeCollection(
                new AttributeMetadata[] { accountid, name, primarycontactid }
                    .Concat(GlobalMetadata.GetGlobalMetadata())
                    .Concat(GlobalMetadata.GetOwnerMetadata())
                    .Concat(GlobalMetadata.GetProcessMetadata())
                    .ToArray());

            return metadata;
        }
    }
}
