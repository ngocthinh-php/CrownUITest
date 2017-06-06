using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SalesForce.TestSteps
{
    [Binding]
    public sealed class DeleteTestDataCreatedSteps
    {
        [Given(@"I am in Contact Screen")]
        public void GivenIAmInContactScreen()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click the Delete button on (.*)")]
        public void WhenIClickTheDeleteButtonOn(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the contact record should be deleted successfully")]
        public void ThenTheContactRecordShouldBeDeletedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I am in Case Screen")]
        public void GivenIAmInCaseScreen()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the case record should be deleted successfully")]
        public void ThenTheCaseRecordShouldBeDeletedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I am in organisation Screen")]
        public void GivenIAmInOrganisationScreen()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the organisation record should be deleted successfully")]
        public void ThenTheOrganisationRecordShouldBeDeletedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
