using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_7_питпм
{   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Пока!";
            label1.ForeColor = Color.Yellow;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Privet!";
            label1.ForeColor = Color.Blue;
        }
    }
}
