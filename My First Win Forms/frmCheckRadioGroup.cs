using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_Win_Forms
{
    public partial class frmCheckRadioGroup : Form
    {
        public frmCheckRadioGroup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { 
            button1.Enabled = checkBox1.Checked;
        }
    }
}
