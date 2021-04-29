using Dataverse.Sdk.Extensions.Samples.EarlyBoundEntities;
using Microsoft.Xrm.Sdk;
using System;

namespace Dataverse.Sdk.Extensions.Samples
{
    public class SystemTypesSamples
    {
        public void ConvertGuidToEntityReference(Guid id)
        {
            EntityReference er = id.ToEntityReference("account");
        }

        public void ConvertGuidToEntityReferenceWithGeneric(Guid id)
        {
            EntityReference er = id.ToEntityReference<Account>();
        }
    }
}