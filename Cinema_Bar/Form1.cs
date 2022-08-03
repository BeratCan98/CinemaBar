using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int popcorn=Convert.ToInt32(textBox2.Text);
            int coke= Convert.ToInt32(textBox3.Text);
            int water= Convert.ToInt32(textBox4.Text);
            int ticket= Convert.ToInt32(textBox1.Text);
            int total = popcorn*20 + coke*10 + water*5 + ticket*50;
            textBox5.Text = total.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Focus();
        }
    }
}
