using CrownUITest.Hooks;
using CrownUITest.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium;

namespace CrownUITest.TestSteps
{
    [Binding]
    public sealed class PortalForgotPasswordSteps
    {
        [Given(@"Buyer is in portal login page")]
        public void GivenBuyerIsInPortalLoginPage()
        {
            Assert.IsTrue(TestBase.login.PageTitle.Displayed);
        }

        [When(@"clicks on forgot your password link")]
        public void WhenClicksOnForgotYourPasswordLink()
        {
            TestBase.login.ClickOnForgottenPassword();
        }

        [Then(@"Reset your password page should get loaded")]
        public void ThenResetYourPasswordPageShouldGetLoaded()
        {
            Assert.IsTrue(TestBase.forgotpassword.PageTitle.Displayed);
        }

        [When(@"Buyer enters (.*)")]
        public void WhenBuyerEnters(string email)
        {
            TestBase.forgotpassword.EnterPwdResetEmail(email);
        }

        [When(@"clicks on send password reset email button")]
        public void WhenClicksOnSendPasswordResetEmailButton()
        {
            TestBase.forgotpassword.ClickOnSendPwdResetEmil();
        }

        [Then(@"user should be navigated to email confirmation page")]
        public void ThenUserShouldBeNavigatedToEmailConfirmationPage()
        {
            TestBase.passwordresetemail.VerifyPage();
        }
    }
}
