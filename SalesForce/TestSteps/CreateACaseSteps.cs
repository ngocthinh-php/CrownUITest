using NUnit.Framework;
using SalesForce.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SalesForce.TestSteps
{
    [Binding]
    public sealed class CreateACaseSteps
    {
        [Given(@"I am on Cases page")]
        public void GivenIAmOnCasesPage()
        {
            TestBase.landing.ClickOnCasesTab();
            Thread.Sleep(2000);
            TestBase.cases.VerifyPage();
            Thread.Sleep(2000);
        }
        [When(@"I click on New button")]
        public void WhenIClickOnNewButton()
        {
            TestBase.cases.ClickOnNewButton();
        }

        [Then(@"I should be navigated to Case type Selection page")]
        public void ThenIShouldBeNavigatedToCaseTypeSelectionPage()
        {
            TestBase.newCase.VerifyPage();
        }

        [When(@"I select case Type as (.*)")]
        public void WhenISelectCaseTypeAs(string caseType)
        {
            TestBase.newCase.SelectCaseType(caseType);
            Thread.Sleep(2000);
            TestBase.newCase.ClickOnContinueButton();
            Thread.Sleep(2000);
        }

        [Then(@"I should be presented with Case Edit screen")]
        public void ThenIShouldBePresentedWithCaseEditScreen()
        {
            TestBase.caseEdit.VerifyPage();
            Thread.Sleep(2000);
        }

        [When(@"I populate mandatory information (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) for the case and Save the record")]
        public void WhenIPopulateMandatoryInformationForTheCaseAndSaveTheRecord(string orgName, string contactName, string team, string status, string priority, string triageLevel, string caseOrigin, string subject, string description)
        {
            //TestBase.caseEdit.EnterOrganisationName(orgName);
            //TestBase.caseEdit.EnterContactName(contactName);
            //TestBase.caseEdit.SelectATeam(team);
            //Thread.Sleep(2000);
            //TestBase.caseEdit.SelectCaseStatus(status);
            //Thread.Sleep(2000);
            //TestBase.caseEdit.SelectCasePriority(priority);
            //Thread.Sleep(2000);
            //TestBase.caseEdit.EnterTriageLevel(triageLevel);
            //Thread.Sleep(2000);
            //TestBase.caseEdit.SelectCaseOrigin(caseOrigin);
            //Thread.Sleep(2000);
            //TestBase.caseEdit.EnterCaseSubject(subject);
            //TestBase.caseEdit.EnterCaseDescription(description);
            //Thread.Sleep(2000);
            TestBase.caseEdit.CreateEnquiryCase(orgName, contactName, team, status, priority, triageLevel, caseOrigin, subject, description);
        }

        [Then(@"a Case record be created successfully")]
        public void ThenACaseRecordBeCreatedSuccessfully()
        {
            TestBase.caseEdit.ClickOnBottomSaveBtn();
            Thread.Sleep(2000);
        }
    }
}
