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
    public partial class WizardFrontend : Form
    {
        public WizardFrontend()
        {
            InitializeComponent();
        }

        public WizardFrontend(BaseWizardLogic logic) : this()
        {
            this.pictureBox1.Image = logic.Logo;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Text = logic.Title;
            this.propertyGrid1.SelectedObject = logic;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO I need to do something do update selectedobject in propertygrid?
            this.Dispose();

        }

    }
}
