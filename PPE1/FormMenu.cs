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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonPrograme_Click(object sender, EventArgs e)
        {
            FormProgramerBis dlr = new FormProgramerBis();
            dlr.ShowDialog();
        }

        private void buttonConsulte_Click(object sender, EventArgs e)
        {
            FormConsulterBis dlr = new FormConsulterBis();
            dlr.ShowDialog();
        }
    }
}
