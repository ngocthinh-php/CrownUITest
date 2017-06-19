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

        [When(@"I enter user details (.*),(.*)")]
        public void WhenIEnterUserDetails(string email, string password)
        {
            TestBase.login.UserLogin(email, password);
            Thread.Sleep(5000);
            TestBase.login.ClickOnRememberMe();
            Thread.Sleep(3000);

        }

        [When(@"I click on Login button")]
        public void WhenIClickOnLoginButton()
        {
            TestBase.login.ClickOnLogIn();
            Thread.Sleep(5000);
        }

        [Then(@"I should be navigated to landingpage")]
        public void ThenIShouldBeNavigatedToLandingpage()
        {
            TestBase.landing.VerifyPage();
        }

        [Then(@"I should see Error Message(.*)")]
        public void ThenIShoulSeeErrorMessage(string errormessage)
        {
            Assert.IsTrue(TestBase.login.ErrorMessage.Displayed);
            Assert.AreEqual(errormessage, TestBase.login.ErrorMessage.Text);
        }     
    }
}