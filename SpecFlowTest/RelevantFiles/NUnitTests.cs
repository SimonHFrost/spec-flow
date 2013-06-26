using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTest
{
    [TestFixture]
    class NUnitTests
    {
        [Test]
        public void TestGoodButton()
        {
            Form1 form = new Form1();
            
            form.textBox1.Text = "0";
            Assert.AreEqual("0", form.textBox1.Text);

            form.button1_Click(null, null);
            Assert.AreEqual("1", form.textBox1.Text);
        }

        [Test]
        public void TestFaultyButton()
        {
            Form1 form = new Form1();

            form.textBox1.Text = "0";
            Assert.AreEqual("0", form.textBox1.Text);

            form.button2_Click(null, null);
            Assert.AreEqual("1", form.textBox1.Text);
        }

        [Test]
        public void TestArbitraryStart()
        {
            Form1 form = new Form1();

            form.textBox1.Text = "8008135";

            form.button1_Click(null, null);
            Assert.AreEqual("8008136", form.textBox1.Text);
        }

        [Test]
        public void TestMultipleClicks()
        {
            Form1 form = new Form1();

            form.textBox1.Text = "0";

            form.button1_Click(null, null);
            form.button1_Click(null, null);
            form.button1_Click(null, null);

            Assert.AreEqual("3", form.textBox1.Text);
        }
    }
}
