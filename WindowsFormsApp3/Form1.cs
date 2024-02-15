﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Текст выведен на метку";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Enabled = false; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            button7.Left += rnd.Next(-100, 100);
            button7.Top +=rnd.Next(-100, 100);
        }
    }
}
