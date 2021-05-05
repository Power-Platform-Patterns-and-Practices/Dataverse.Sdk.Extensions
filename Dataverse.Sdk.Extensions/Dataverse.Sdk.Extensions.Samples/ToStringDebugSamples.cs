using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace Dataverse.Sdk.Extensions.Samples
{
    public class ToStringDebugSamples
    {
        public void ToStringDebugEntity()
        {
            var display = new Entity().ToStringDebug();
        }

        public void ToStringDebugEntityCollection(IOrganizationService service, QueryExpression qe)
        {
            var display = service.RetrieveMultiple(qe).ToStringDebug();
        }

        public void ToStringDebugContext(IPluginExecutionContext context)
        {
            var display = context.ToStringDebug();
        }
    }
}
