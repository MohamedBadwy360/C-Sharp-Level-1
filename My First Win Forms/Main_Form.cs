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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShowPart1_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.Show();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.ShowDialog();
        }

        private void btnShowMessageForm_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMessageBox();
            frm1.ShowDialog();
        }

        private void btnShowGroupForm_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmCheckRadioGroup();
            frm1.ShowDialog();
        }
    }
}
