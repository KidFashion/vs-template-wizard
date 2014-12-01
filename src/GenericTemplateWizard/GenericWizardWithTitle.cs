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

using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPSoftware.VisualStudio.GenericTemplateWizard
{
    public abstract class GenericWizardWithTitle<T> : IWizard where T : BaseWizardLogic, new()
    {

        protected T logic;
        protected WizardFrontendWithTitle frontend;

        public GenericWizardWithTitle()
        {
            this.logic = new T();
        }
        public GenericWizardWithTitle(T logic)
        {
            this.logic = logic;
        }

        public virtual void BeforeOpeningFile(EnvDTE.ProjectItem projectItem)
        {
        }

        public virtual void ProjectFinishedGenerating(EnvDTE.Project project)
        {
        }

        public virtual void ProjectItemFinishedGenerating(EnvDTE.ProjectItem projectItem)
        {
        }

        public virtual void RunFinished()
        {

            //TODO: Reset GlobalDictionary
        }

        public virtual void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            frontend = new WizardFrontendWithTitle(logic);
            frontend.ShowDialog();
            SetReplacementDictionary(logic, ref replacementsDictionary);
            if (logic.GlobalVariablesIsEnabled) { GlobalDictionary.CopyReplacementsDictionaryToGlobalDictionary(ref replacementsDictionary); }
        }

        protected void SetReplacementDictionary(T logic, ref Dictionary<string, string> replacementsDictionary)
        {

            foreach (var prop in logic.GetType().GetProperties())
            {
                if (prop.Name == "Logo" || prop.Name == "Title") continue;
                replacementsDictionary[String.Concat("$", prop.Name.ToLower(), "$")] = prop.GetValue(logic).ToString();
            }
        }

        public virtual bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
