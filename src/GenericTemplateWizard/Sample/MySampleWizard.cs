using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTemplateWizard.Sample
{
    public class MySampleWizard : GenericTemplateWizard.GenericWizard<SampleWizardLogic>
    {
    }

    public class MyPassThruSampleWizard : GenericTemplateWizard.PropagateParametersTemplateWizard<SampleWizardLogic>
    {
    }

}
