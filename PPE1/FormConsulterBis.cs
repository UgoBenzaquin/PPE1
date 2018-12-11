using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE1
{
    
    public partial class FormConsulterBis : Form
    {
        private int choix = 0;
        public FormConsulterBis()
        {
            InitializeComponent();
        }

        private void radioButtonIntervetion_CheckedChanged(object sender, EventArgs e)
        {
            choix = 1;
        }

        private void radioButtonClient_CheckedChanged(object sender, EventArgs e)
        {
            choix = 2;
        }

        private void radioButtonMateriel_CheckedChanged(object sender, EventArgs e)
        {
            choix = 3;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (choix == 0)
            {
                ButtonOK.Enabled = false;
            }
            if (choix == 1)
            {
                FormIntervention dlr = new FormIntervention();
                dlr.ShowDialog();

            }
            if (choix == 2)
            {
                FormClient dlr = new FormClient();
                dlr.ShowDialog();

            }
            if (choix == 3)
            {
                FormMaterielle dlr = new FormMaterielle();
                dlr.ShowDialog();
            }

        }
    }
}
