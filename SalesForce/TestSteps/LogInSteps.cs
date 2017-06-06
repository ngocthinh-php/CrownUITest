using SalesForce.Hooks;
using TechTalk.SpecFlow;
using System.Threading;
using NUnit.Framework;

namespace SalesForce.TestSteps
{
    [Binding]
    public sealed class LogInSteps
    {
        [Given(@"I have navigated to Salesforce login page")]
        public void GivenIHaveNavigatedToSalesforceLoginPage()
        {
            TestBase.login.VerifyPage();
            Thread.Sleep(3000);
        }

        [When(@"I enter user details with (.*) and (.*)")]
        public void WhenIEnterUserDetailsWithEmailAndPassword(string email, string password)
        {
            TestBase.login.UserLogin(email, password);
            Thread.Sleep(5000);
        }

        [When(@"I click on Remember Me check box")]
        public void WhenIClickOnRememberMeCheckBox()
        {
            TestBase.login.ClickOnRememberMe();
            Thread.Sleep(3000);
        }

        [When(@"I click on Login button")]
        public void WhenIClickOnLoginButton()
        {
            TestBase.login.ClickOnLogIn();
            Thread.Sleep(5000);
        }

        [Then(@"I should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            TestBase.landing.VerifyPage();
        }

       
    }
}