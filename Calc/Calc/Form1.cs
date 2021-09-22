using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void Formula_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }
    }
}
