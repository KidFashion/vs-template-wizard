using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericTemplateWizard
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
