namespace SalesForce.TestSteps
{
    #region Using Directives
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using OpenQA.Selenium;
    using NUnit.Framework;
    using SalesForce.Hooks;
    using TechTalk.SpecFlow;
    #endregion

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