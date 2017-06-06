using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SalesForce.TestSteps
{
    [Binding]
    public sealed class CreateACaseSteps
    {
        [Given(@"I am on Case screen")]
        public void GivenIAmOnCaseScreen()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should be navigated to Case type Selection page")]
        public void ThenIShouldBeNavigatedToCaseTypeSelectionPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I select case Type as (.*)")]
        public void WhenISelectCaseTypeAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should be presented with ""(.*)"" screen")]
        public void ThenIShouldBePresentedWithScreen(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I populate mandatory information for the case and Save the record")]
        public void WhenIPopulateMandatoryInformationForTheCaseAndSaveTheRecord()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"an Case be created successfully")]
        public void ThenAnCaseBeCreatedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
