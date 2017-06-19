using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SalesForce.TestSteps
{
    [Binding]
    class SurveyFeedbackObjectSteps
    {
        [Given(@"I am in SetUp page")]
        public void GivenIAmInSetUpPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I search for ""(.*)"" in quick search box")]
        public void WhenISearchForInQuickSearchBox(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I load the ""(.*)""")]
        public void WhenILoadThe(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should be able to validate the Improve , its associated Improve__c and Long Text Area\((.*)\)")]
        public void ThenIShouldBeAbleToValidateTheImproveItsAssociatedImprove__CAndLongTextArea(int p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
