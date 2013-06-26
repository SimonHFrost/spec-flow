using System;
using System.Windows.Forms;

namespace SpecFlowTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int plusOne = int.Parse(textBox1.Text) + 1;
            textBox1.Text = plusOne.ToString();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "BLARGH";
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
