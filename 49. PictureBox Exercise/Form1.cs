using _49.PictureBox_Exercise.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _49.PictureBox_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                pbImage.Image = Resources.Boy;
                lblTitle.Text = "Boy";
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                pbImage.Image = Resources.Girl;
                lblTitle.Text = "Girl";
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                pbImage.Image = Resources.Pen;
                lblTitle.Text = "Pen";
            }
            else
            {
                pbImage.Image = Resources.Book;
                lblTitle.Text = "Book";
            }
        }
    }
}
