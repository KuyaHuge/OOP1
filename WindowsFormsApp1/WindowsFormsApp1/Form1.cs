using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, n4, n5;

            if (!int.TryParse(textBox1.Text, out n1) ||
                !int.TryParse(textBox2.Text, out n2) ||
                !int.TryParse(textBox3.Text, out n3) ||
                !int.TryParse(textBox4.Text, out n4) ||
                !int.TryParse(textBox5.Text, out n5))
            {
                MessageBox.Show("Please enter valid numbers in all fields.");
                return;
            }

            int total = n1 + n2 + n3 + n4 + n5;
            int dozen = total / 12;
            int remainder = total % 12;

            label3.Text = total + " Eggs is " + dozen + " dozens and " + remainder + " left over";


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
