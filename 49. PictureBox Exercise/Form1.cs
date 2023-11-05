﻿using _49.PictureBox_Exercise.Properties;
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

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {
                pbImage.Image = Resources.Boy;
                lblTitle.Text = ((RadioButton) sender).Tag.ToString();
        }

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
                pbImage.Image = Resources.Girl;
                lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
                pbImage.Image = Resources.Book;
                lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {
                pbImage.Image = Resources.Pen;
                lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbBoy.Checked = true;
        }
    }
}
