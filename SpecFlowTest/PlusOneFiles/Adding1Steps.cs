using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTest
{
    [Binding]
    public class Adding1ToNumbersSteps
    {
        private MainWindow mainWindow = new MainWindow();

        [Given(@"I have entered (.*) into the textbox")]
        public void GivenIHaveEnteredIntoTheTextbox(int p0)
        {
            mainWindow.textBox1.Text = p0.ToString();
        }
        
        [When(@"I press the good button")]
        public void WhenIPressTheGoodButton()
        {
            mainWindow.button1_Click(null, null);
        }

        [When(@"I press the good button (.*) times")]
        public void WhenIPressTheGoodButtonTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                mainWindow.button1_Click(null, null);
            }
        }
        
        [When(@"I press the faulty button")]
        public void WhenIPressTheFaultyButton()
        {
            mainWindow.button2_Click(null, null);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            string value = mainWindow.textBox1.Text;
            Assert.AreEqual(result.ToString(), value);
        }
    }
}
