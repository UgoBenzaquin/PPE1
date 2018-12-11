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
    public partial class FormCONNEXION : Form
    {
        public FormCONNEXION()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FormMenu Co = new FormMenu();
            Co.ShowDialog();
            Close();
        }
    }
}
