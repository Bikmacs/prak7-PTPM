using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Blue;
            textBox1.Text = "Щелчок по кнопке 1";
            textBox1.ForeColor = System.Drawing.Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;
            textBox1.Text = "Щелчок по кнопке 3";
            textBox1.ForeColor = System.Drawing.Color.Yellow;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Green;
            textBox1.Text = "Щелчок по кнопке 3";
            textBox1.ForeColor = System.Drawing.Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Gray;
            textBox1.Text = "Щелчок по кнопке 4";
            textBox1.ForeColor = System.Drawing.Color.Blue;
        }
    }
}
