using TechTalk.SpecFlow;

namespace SpecFlowTest.ApiFiles
{
    [Binding]
    public class ApiTestingSteps
    {
        [Given(@"I am logged in as customer '(.*)'")]
        public void GivenIAmLoggedInAsCustomer(string login)
        {
            // AccountManager.Login(login, GetPassword(login));
        }
        
        [Given(@"I have (.*) of my customers ready to import")]
        public void GivenIHaveOfMyCustomersReadyToImport(int numCustomers)
        {
            // _rows = CsvManager.GetRowsForUser(_currentLogin, numCustomers);
        }
        
        [When(@"I import these customers")]
        public void WhenIImportTheseCustomers()
        {
            // ApiImportCustomers("import", _rows);
        }

        [Then(@"I want to verify that they exist")]
        public void ThenIWantToSeeThemDisplayedInRoute()
        {
            // List<Customer> customers = GetAllCustomers(_currentLogin);
        }
    }
}
