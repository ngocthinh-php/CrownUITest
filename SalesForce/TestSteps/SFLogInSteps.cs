using SalesForce.Pages;
using SalesForce.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace SalesForce.TestSteps
{
    [Binding]
    public sealed class SFLogInSteps
    {
        [Given(@"I have navigated to Salesforce login page")]
        public void GivenIHaveNavigatedToSalesforceLoginPage()
        {
            SFTestBase.login.VerifyPage();
            Thread.Sleep(3000);
        }

        [When(@"I enter user details with (.*) and (.*)")]
        public void WhenIEnterUserDetailsWithEmailAndPassword(string email, string password)
        {
            SFTestBase.login.UserLogin(email, password);
            Thread.Sleep(5000);
        }

        [When(@"I click on Remember Me check box")]
        public void WhenIClickOnRememberMeCheckBox()
        {
            SFTestBase.login.ClickOnRememberMe();
            Thread.Sleep(3000);
        }

        [When(@"I click on Login button")]
        public void WhenIClickOnLoginButton()
        {
            SFTestBase.login.ClickOnLogIn();
            Thread.Sleep(5000);
        }

        [Then(@"I should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            SFTestBase.home.VerifyPage();
        }

       
    }
}