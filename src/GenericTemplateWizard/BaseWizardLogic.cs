using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GenericTemplateWizard
{
    public abstract class BaseWizardLogic
    {
        public BaseWizardLogic(Bitmap logo, String title)
        {
            this.logo = logo;
            this.title = title;
        }

        private Bitmap logo;
        [Browsable(false)]
        public Bitmap Logo { get { return logo; } }

        private String title;
        [Browsable(false)]
        public String Title { get { return title; } }

        [Browsable(false)]
        public bool GlobalVariablesIsEnabled { get { return useGlobalVariables; } }

        private bool useGlobalVariables = false;

        [Obsolete("Visual Studio 2013 Update2 adds a better way to manage multi-project template parameters: http://stackoverflow.com/questions/19662836/using-customparamter-with-visual-studio-multi-project-template")]
        public void UseGlobalVariables() { useGlobalVariables = true; }

        protected Size size = new Size(0,0);

        [Browsable(false)]
        public Size FormSize
        {
            get { return size;}
        }
    }
}
