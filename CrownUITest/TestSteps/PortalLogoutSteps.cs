using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CrownUITest.TestSteps
{
    [Binding]
    public sealed class PortalLogoutSteps
    {
        [Given(@"I am on portal page")]
        public void GivenIAmOnPortalPage()
        {
            //TO DO
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on log out option from the profile menu")]
        public void WhenIClickOnLogOutOptionFromTheProfileMenu()
        {
            //TO DO
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should be logged out of the profile")]
        public void ThenIShouldBeLoggedOutOfTheProfile()
        {
            //TO DO
            ScenarioContext.Current.Pending();
        }
    }
}
