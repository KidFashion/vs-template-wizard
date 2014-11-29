using System;
using System.Collections.Generic;
using System.ComponentModel;
#region LICENSE
/*
 *   Copyright 2014 Angelo Simone Scotto <scotto.a@gmail.com>
 * 
 *   Licensed under the Apache License, Version 2.0 (the "License");
 *   you may not use this file except in compliance with the License.
 *   You may obtain a copy of the License at
 * 
 *       http://www.apache.org/licenses/LICENSE-2.0
 * 
 *   Unless required by applicable law or agreed to in writing, software
 *   distributed under the License is distributed on an "AS IS" BASIS,
 *   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *   See the License for the specific language governing permissions and
 *   limitations under the License.
 * 
 * */
#endregion

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
