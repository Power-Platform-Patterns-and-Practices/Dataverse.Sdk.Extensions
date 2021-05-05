using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;

namespace Dataverse.Sdk.Extensions.Samples
{
    public class EntityReferenceSamples
    {
        public void GetNameId()
        {
            var display = ((EntityReference)null).GetNameId();   
            display = new EntityReference("account", Guid.NewGuid()).GetNameId();
            display = new EntityReference("account", Guid.NewGuid()){ Name = "Bart Simpson"}.GetNameId();
        }
    }
}
