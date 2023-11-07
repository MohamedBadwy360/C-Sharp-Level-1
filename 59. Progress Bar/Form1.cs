﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _59.Progress_Bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (byte i = 0; i < 10; i++)
            {
                if (progressBar1.Value <= progressBar1.Maximum)
                {
                    Thread.Sleep(500);
                    progressBar1.Value += 10;
                    progressBar1.Refresh();
                    label1.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100) + " %";
                    label1.Refresh();
                    
                }
                else
                {
                    button1.Enabled = false;
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            progressBar1.Value = 0;
            label1.Text = 0 + " %";
        }
    }
}
