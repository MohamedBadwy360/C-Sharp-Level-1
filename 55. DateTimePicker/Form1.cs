using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _55.DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToLongDateString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.Start.ToShortDateString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.End.ToShortDateString());
        }
    }
}
