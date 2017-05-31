using CrownUITest.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CrownUITest.TestSteps
{
    [Binding]
    public sealed class PortalUserRegistrationSteps
    {
        [Given(@"I am on portal login page")]
        public void GivenIAmOnPortalLoginPage()
        {
            Assert.IsTrue(TestBase.login.PageTitle.Displayed);
            TestBase.login.VerifyPage();
        }

        [When(@"I click on Register link")]
        public void WhenIClickOnRegisterLink()
        {
            TestBase.login.ClickOnRegister();
            Thread.Sleep(5000);
        }

        [Then(@"I should be navigated to the self register page")]
        public void ThenIShouldBeNavigatedToTheSelfRegisterPage()
        {
            TestBase.userreg.VerifyPage();
        }

        [When(@"I select the option Public Sector")]
        public void WhenISelectTheOptionPublicSector()
        {
            TestBase.userreg.ClickOnPublicSectorRadioBtn();
            Thread.Sleep(5000);
            TestBase.userreg.VerifyPublicOption();
        }

        [When(@"I enter my details (.*) and (.*) and (.*)")]
        public void WhenIEnterMyDetailsFirstNameAndLastNameAndEmail(string firstName, string lastName, string email)
        {
            TestBase.userreg.UserEntersInitialInfo(firstName, lastName, email);
            Thread.Sleep(5000);
        }

        [When(@"I click on TnC checkbox")]
        public void WhenIClickOnTnCCheckbox()
        {
            TestBase.userreg.ClickOnTnCCheckBox();
            Thread.Sleep(5000);
        }

        [When(@"I click on Sign Up button")]
        public void WhenIClickOnSignUpButton()
        {
            TestBase.userreg.ClickOnSignUpBtnInitial();
            Thread.Sleep(5000);
        }

        [Then(@"I should be presented with next part of self registration page")]
        public void ThenIShouldBePresentedWithNextPartOfSelfRegistrationPage()
        {
            TestBase.userreg.VerifyPublicOptionPart2();
        }

        [When(@"I enter contactnumber as (.*)")]
        public void WhenIEnterContactnumberAs(string contactNumber)
        {
            TestBase.userreg.UserEnterContactNumber(contactNumber);
            Thread.Sleep(2000);
        }

        [When(@"select organisation as (.*)")]
        public void WhenSelectOrganisationAs(string organisation)
        {
            TestBase.userreg.SelectYourOrganisation(organisation);
            Thread.Sleep(3000);
        }

        [When(@"click on new SignUp button")]
        public void WhenClickOnNewSignUpButton()
        {
            TestBase.userreg.ClickOnSignUpBtnFinal();
            Thread.Sleep(5000);
        }

        [Then(@"I should see registration confirmation page")]
        public void ThenIShouldSeeRegistrationConfirmationPage()
        {
            TestBase.regconfirm.VerifyPage();
        }

        /// <summary>
        /// Login failure - email address already registered
        /// </summary>
        [Then(@"I should be presented with a message saying email address registered")]
        public void ThenIShouldBePresentedWithAMessageSayingEmailAddressRegistered()
        {
            TestBase.userreg.RegistrationFailureEmailAddressRegistered();
        }
        /// <summary>
        /// When user selects organisation as Other as part of Registration
        /// </summary>
        [Then(@"a new text box appears")]
        public void ThenANewTextBoxAppears()
        {
            TestBase.userreg.VerifyOtherOrganisationField();
            Thread.Sleep(3000);
        }
        /// <summary>
        /// User enters new organisation name
        /// </summary>
        /// <param name="otherOrganisation"></param>
        [When(@"I enter new organisation details as (.*)")]
        public void WhenIEnterNewOrganisationDetailsAsNewOrganisation(string otherOrganisation)
        {
            TestBase.userreg.UserEntersOtherOrganisation(otherOrganisation);
            Thread.Sleep(3000);
        }

        [When(@"click on another SignUp button")]
        public void WhenClickOnAnotherSignUpButton()
        {
            TestBase.userreg.ClickOnSignUpBtnOther();
            Thread.Sleep(5000);
        }
        /// <summary>
        /// Private Sector Registration
        /// </summary>
        [When(@"I select the option Private Sector")]
        public void WhenISelectTheOptionPrivateSector()
        {
            TestBase.userreg.ClickOnPrivateSectorRadioBtn();
            Thread.Sleep(5000);
        }

        [Then(@"I should be presented with a new page that says to use SID4GOV to Register")]
        public void ThenIShouldBePresentedWithANewPageThatSaysToUseSIDGOVToRegister()
        {
            TestBase.userreg.VerifyPrivateOption();
        }
    }
}
