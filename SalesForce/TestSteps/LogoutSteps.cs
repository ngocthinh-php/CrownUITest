using SalesForce.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SalesForce.TestSteps
{
    [Binding]
    public sealed class SalesforceLogoutSteps
    {
        [Given(@"I am Logged in to Salesforce")]
        public void GivenIAmOnSalesforcePage()
        {
            TestBase.landing.VerifyPage();
        }

        [When(@"I click on logout option")]
        public void WhenIClickOnLogoutOption()
        {
            TestBase.landing.ClickOnProfileHeader();
            TestBase.landing.ClickOnLogout();
        }

        [Then(@"I should be logged out of the Salesforce application")]
        public void ThenIShouldBeLoggedOutOfTheSalesforceApplication()
        {
            TestBase.login.VerifyPage();
        }
    }
}
