using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTest
{
    [Binding]
    public class Adding1ToNumbersSteps
    {
        private Form1 form = new Form1();

        [Given(@"I have entered (.*) into the textbox")]
        public void GivenIHaveEnteredIntoTheTextbox(int p0)
        {
            form.textBox1.Text = p0.ToString();
        }
        
        [When(@"I press the good button")]
        public void WhenIPressTheGoodButton()
        {
            form.button1_Click(null, null);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            string value = form.textBox1.Text;
            Assert.AreEqual(p0, value);
        }
    }
}
