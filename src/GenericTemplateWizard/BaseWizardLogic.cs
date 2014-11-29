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
