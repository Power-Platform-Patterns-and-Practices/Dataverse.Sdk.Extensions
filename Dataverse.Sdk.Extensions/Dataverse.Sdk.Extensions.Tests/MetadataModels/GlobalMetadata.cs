using Microsoft.Xrm.Sdk.Metadata;
using System.Collections.Generic;
using FakeXrmEasy.Extensions;

namespace Dataverse.Sdk.Extensions.Tests.MetadataModels
{
    class GlobalMetadata
    {
        public static IEnumerable<AttributeMetadata> GetGlobalMetadata()
        {
            var createdon = new DateTimeAttributeMetadata(DateTimeFormat.DateAndTime, "createdon")
            {
                LogicalName = "createdon"
            };
            yield return createdon;
            var createdonbehalfby = new LookupAttributeMetadata()
            {
                SchemaName = "createdonbehalfby",
                LogicalName = "createdonbehalfby"
            };
            yield return createdonbehalfby;
            var createdby = new LookupAttributeMetadata()
            {
                SchemaName = "createdby",
                LogicalName = "createdby"
            };
            yield return createdby;
            var modifiedon = new DateTimeAttributeMetadata(DateTimeFormat.DateAndTime, "modifiedon")
            {
                LogicalName = "modifiedon"
            };
            yield return modifiedon;
            var modifiedonbehalfby = new LookupAttributeMetadata()
            {
                SchemaName = "modifiedonbehalfby",
                LogicalName = "modifiedonbehalfby"
            };
            yield return modifiedonbehalfby;
            var modifiedby = new LookupAttributeMetadata()
            {
                SchemaName = "modifiedby",
                LogicalName = "modifiedby"
            };
            yield return modifiedby;
            var overridencreatedon = new DateTimeAttributeMetadata(DateTimeFormat.DateAndTime, "overridencreatedon")
            {
                LogicalName = "overridencreatedon"
            };
            yield return overridencreatedon;
            var overridencreatedby = new LookupAttributeMetadata()
            {
                SchemaName = "overridencreatedby",
                LogicalName = "overridencreatedby"
            };
            yield return overridencreatedby;
            var statecode = new StateAttributeMetadata()
            {
                SchemaName = "statecode",
                LogicalName = "statecode"
            };
            yield return statecode;
        }

        public static IEnumerable<AttributeMetadata> GetProcessMetadata()
        {
            var stageid = new UniqueIdentifierAttributeMetadata("StageId")
            {
                LogicalName = "stageid"
            };
            stageid.SetSealedPropertyValue(nameof(stageid.IsValidForCreate), true);
            yield return stageid;
            var processid = new UniqueIdentifierAttributeMetadata("ProcessId")
            {
                LogicalName = "processid"
            };
            processid.SetSealedPropertyValue(nameof(processid.IsValidForCreate), true);
            yield return processid;
        }

        public static IEnumerable<AttributeMetadata> GetOwnerMetadata()
        {
            var ownerid = new LookupAttributeMetadata()
            {
                SchemaName = "ownerid",
                LogicalName = "ownerid"
            };
            yield return ownerid;
        }
    }
}
