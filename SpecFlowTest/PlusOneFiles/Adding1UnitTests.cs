using NUnit.Framework;

namespace SpecFlowTest
{
    [TestFixture]
    class NUnitTests
    {
        [Test]
        public void ClickTheGoodButton()
        {
            MainWindow form = new MainWindow();
            
            form.textBox1.Text = "0";
            Assert.AreEqual("0", form.textBox1.Text);

            form.button1_Click(null, null);
            Assert.AreEqual("1", form.textBox1.Text);
        }

        [Test]
        public void ClickTheGoodButtonMultipleTimes()
        {
            MainWindow form = new MainWindow();

            form.textBox1.Text = "0";

            form.button1_Click(null, null);
            form.button1_Click(null, null);
            form.button1_Click(null, null);

            Assert.AreEqual("3", form.textBox1.Text);
        }

        [Test]
        public void ClickTheFaultyButton()
        {
            MainWindow form = new MainWindow();

            form.textBox1.Text = "0";
            Assert.AreEqual("0", form.textBox1.Text);

            form.button2_Click(null, null);
            Assert.AreEqual("1", form.textBox1.Text);
        }
    }
}
