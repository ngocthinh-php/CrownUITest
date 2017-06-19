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
    public sealed class DeleteTestDataSteps
    {
        [Given(@"user is in landing page")]
        public void GivenUserIsInLandingPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I am on the Mass Delete Cases Page")]
        public void GivenIAmOnTheMassDeleteCasesPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I filter based on Contact and Customer")]
        public void WhenIFilterBasedOnContactAndCustomer()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press Delete button")]
        public void WhenIPressDeleteButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"all the related case records are deleted")]
        public void ThenAllTheRelatedCaseRecordsAreDeleted()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I am on the Mass Delete Contact Page")]
        public void GivenIAmOnTheMassDeleteContactPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I filter based on Contact and Test")]
        public void WhenIFilterBasedOnContactAndTest()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"all the related contact records are deleted")]
        public void ThenAllTheRelatedContactRecordsAreDeleted()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I am on the Mass Delete Accounts Page")]
        public void GivenIAmOnTheMassDeleteAccountsPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I filter based on Supplier")]
        public void WhenIFilterBasedOnSupplier()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"all the related Organisation records are deleted")]
        public void ThenAllTheRelatedOrganisationRecordsAreDeleted()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
