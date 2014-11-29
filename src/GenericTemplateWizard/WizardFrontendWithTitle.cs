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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericTemplateWizard
{
    public partial class WizardFrontendWithTitle : Form
    {
        public WizardFrontendWithTitle()
        {
            InitializeComponent();
        }

        public WizardFrontendWithTitle(BaseWizardLogic logic)
            : this()
        {
            this.pictureBox1.Image = logic.Logo;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Text = logic.Title;
            this.label1.Text = logic.Title;
            this.propertyGrid1.SelectedObject = logic;

            //if size has been declared in WizardLogic use it, otherwise, use default 525; 540
            if (!logic.FormSize.Equals(new Size(0, 0)))
                this.Size = logic.FormSize;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // TODO I need to do something do update selectedobject in propertygrid?
            this.Dispose();

        }

    }
}
