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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2;
            if (
            !int.TryParse(textBox1.Text, out n1) ||
            !int.TryParse(textBox2.Text, out n2)
            ) { 
            MessageBox.Show("Please enter valid numbers in all fields.");
            return;
        }

            int distance = n1 * n2;
            label6.Text = "Distance is " + distance + " m/s";

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
