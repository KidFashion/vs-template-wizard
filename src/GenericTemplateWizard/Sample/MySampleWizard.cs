using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTemplateWizard.Sample
{
    public class MySampleWizard : GenericTemplateWizard.GenericWizardWithTitle<SampleWizardLogic>
    {
    }

    public class MyPassThruSampleWizard : GenericTemplateWizard.PropagateParametersTemplateWizard<SampleWizardLogic>
    {
    }

}
