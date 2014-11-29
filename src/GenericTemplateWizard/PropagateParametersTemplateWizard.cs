using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericTemplateWizard
{
    public class PropagateParametersTemplateWizard<T> : IWizard where T : BaseWizardLogic, new()
    {
        private T logic;
        public PropagateParametersTemplateWizard()
        {
            this.logic = new T();
        }
        public PropagateParametersTemplateWizard(T logic)
        {
            this.logic = logic;
        }

        public void BeforeOpeningFile(EnvDTE.ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(EnvDTE.Project project)
        {
        }

        public void ProjectItemFinishedGenerating(EnvDTE.ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }

        public virtual void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            MessageBox.Show("Lanciato");
            if (logic.GlobalVariablesIsEnabled) { GlobalDictionary.CopyGlobalDictionaryToReplacementsDictionary(ref replacementsDictionary); }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
