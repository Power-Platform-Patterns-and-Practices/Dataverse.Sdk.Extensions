using System;
using FakeXrmEasy;
using FakeXrmEasy.FakeMessageExecutors;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;

namespace Dataverse.Sdk.Extensions.Tests.FakeMessageExecutors
{
    class RetrieveMetadataChangesRequestExecutor : IFakeMessageExecutor
    {
        private EntityMetadataCollection entityMetadata;

        public RetrieveMetadataChangesRequestExecutor(EntityMetadataCollection entityMetadata)
        {
            this.entityMetadata = entityMetadata;
        }

        public bool CanExecute(OrganizationRequest request)
        {
            return request is RetrieveMetadataChangesRequest;
        }

        public OrganizationResponse Execute(OrganizationRequest request, XrmFakedContext ctx)
        {
            return new RetrieveMetadataChangesResponse()
            {
                Results ={
                    ["EntityMetadata"] = entityMetadata
                }
            };
        }

        public Type GetResponsibleRequestType()
        {
            return typeof(RetrieveMetadataChangesRequest);
        }
    }
}
