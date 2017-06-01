using CrownUITest.Hooks;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using CrownUITest.Utilities;

namespace CrownUITest.TestSteps
{
    [Binding]
    public sealed class PortalLoginSteps
    {
        [Given(@"User has navigated to portal login page")]
        public void GivenUserHasNavigatedToPortalLoginPage()
        {
            Assert.IsTrue(TestBase.login.PageTitle.Displayed);
        }

        [When(@"User enters user details with (.*) and (.*)")]
        public void WhenUserEntersUserDetailsWithEmailAndPassword(string email, string password)
        {
            TestBase.login.UserLogin(email, password);
        }

        [When(@"User clicks on Login button")]
        public void WhenUserClicksOnLoginButton()
        {
            TestBase.login.ClickOnLogIn();
//            TestResultUtilities.AddTestPassToTestResultString("Test Setup", "Pass");
        }

        [Then(@"User should be logged in successfully")]
        public void ThenUserShouldBeLoggedInSuccessfully()
        {
            //TestBase.home.VerifyPage();
//            TestBase.print.TestCaptureScreenshot();
            Console.WriteLine("Home Page");
//            TestResultUtilities.AddTestFailToTestResultString("Test Setup", "Fail");

        }

        [Then(@"User should be presented with login failure message")]
        public void ThenUserShouldBePresentedWithLoginFailureMessage()
        {
            TestBase.login.VerifyLoginFailurePage();
        }
    }
}
