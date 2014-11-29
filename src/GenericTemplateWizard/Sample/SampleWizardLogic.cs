using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTemplateWizard.Sample
{
    public class SampleWizardLogic : BaseWizardLogic
    {

        public SampleWizardLogic()
            : base(GenericTemplateWizard.Sample.LogoResource.Logo, "Sample Wizard")
        {
            UseGlobalVariables();
            size = new System.Drawing.Size(800, 800);
        }

        private String solutionName;
        public String SolutionName
        {
            get
            {
                return solutionName;
            }
            set
            { solutionName = value; }
        }
    }
}
