using System;
using System.Windows.Forms;

namespace SpecFlowTest
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int currentValue;
            bool success = int.TryParse(textBox1.Text, out currentValue);
            if (!success)
            {
                textBox1.Text = "0";
                return;
            }
            textBox1.Text = (currentValue + 1).ToString();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " BLARGH";
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
