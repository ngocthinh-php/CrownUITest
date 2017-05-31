using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CrownUITest.TestSteps
{
    [Binding]
    public sealed class SalesforceLogoutSteps
    {
        [Given(@"I am on Salesforce page")]
        public void GivenIAmOnSalesforcePage()
        {
            //TO DO
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on log out option")]
        public void WhenIClickOnLogOutOption()
        {
            //TO DO
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should be logged out of the Salesforce application")]
        public void ThenIShouldBeLoggedOutOfTheSalesforceApplication()
        {
            //TO DO
            ScenarioContext.Current.Pending();
        }
    }
}
