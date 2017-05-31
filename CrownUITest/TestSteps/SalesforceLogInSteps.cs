using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CrownUITest.TestSteps
{
    [Binding]
    public class SalesforceLogInSteps
    {
        [Given(@"I have navigated to Salesforce login page")]
        public void GivenIHaveNavigatedToSalesforceLoginPage()
        {
            ScenarioContext.Current.Pending();
        }

        //[When(@"I enter user details with chitta\.jena@crowncommercial\.gov\.uk\.pemqa and Data@(.*)")]
        //public void WhenIEnterUserDetailsWithChitta_JenaCrowncommercial_Gov_Uk_PemqaAndData(int p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}

        [When(@"I click on Remember Me check box")]
        public void WhenIClickOnRememberMeCheckBox()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on to Login to sandbox button")]
        public void WhenIClickOnToLoginToSandboxButton()
        {
            ScenarioContext.Current.Pending();
        }
    }
}