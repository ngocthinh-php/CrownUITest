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
    public sealed class TSSteps
    {
        [Given(@"C on Cases page")]
        public void GivenCOnCasesPage()
        {
            TestBase.landing.ClickOnCasesTab();
            Thread.Sleep(2000);
            TestBase.cases.VerifyPage();
            Thread.Sleep(2000);
        }
        [When(@"C click on New button")]
        public void WhenCClickOnNewButton()
        {
            TestBase.cases.ClickOnNewButton();
        }

        [Then(@"C should be navigated to Case type Selection page")]
        public void ThenCShouldBeNavigatedToCaseTypeSelectionPage()
        {
            TestBase.newCase.VerifyPage();
        }

        [When(@"C select case Type as (.*) and continue")]
        public void WhenCSelectCaseTypeAsAndContinue(string caseType)
        {
            TestBase.newCase.SelectCaseType(caseType);
            //Thread.Sleep(2000);
            TestBase.newCase.ClickOnContinueButton();
            //Thread.Sleep(2000);
        }

        [Then(@"C should be presented with Case Edit screen")]
        public void ThenCShouldBePresentedWithCaseEditScreen()
        {
            TestBase.caseEdit.VerifyPage();
            //Thread.Sleep(2000);
        }

        [When(@"C populate mandatory Tech Support Case information '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)' for the case and Save the record")]
        public void WhenCPopulateMandatoryTechSupportCaseInformationForTheCaseAndSaveTheRecord( string orgName, string technologyTeam, string caseOrigin, string contactName, string workflow, string category, string status, string priority, string supportClassification, string SCLevel1, string SCLevel2, string subject, string description)
        {
            TestBase.caseEdit.EnterOrganisationName(orgName);
            Thread.Sleep(2000);
            TestBase.caseEdit.EnterContactName(contactName);
            Thread.Sleep(2000);
            TestBase.caseEdit.SelectATechnologyTeam(technologyTeam);
            Thread.Sleep(2000);
            TestBase.caseEdit.SelectCaseOrigin(caseOrigin);
            Thread.Sleep(2000);
            TestBase.caseEdit.SelectWorkflow(workflow);
            Thread.Sleep(2000);
            TestBase.caseEdit.SelectCategory(category);
            Thread.Sleep(2000);
            TestBase.caseEdit.SelectCaseStatus(status);
            Thread.Sleep(2000);
            TestBase.caseEdit.SelectCasePriority(priority);
            Thread.Sleep(2000);
            TestBase.caseEdit.SelectSupportClassification(supportClassification);
            Thread.Sleep(2000);
            TestBase.caseEdit.SelectSCLevel1(SCLevel1);
            Thread.Sleep(2000);
            TestBase.caseEdit.SelectSCLevel2(SCLevel2);
            Thread.Sleep(2000);
            TestBase.caseEdit.EnterCaseSubject(subject);
            Thread.Sleep(2000);
            TestBase.caseEdit.EnterCaseDescription(description);
            Thread.Sleep(2000);
            //TestBase.caseEdit.CreateTechSupportCase(orgName, contactName, technologyTeam, caseOrigin, workflow, category, status, priority, supportClassification, SCLevel1, SCLevel2, subject, description);
        }

        [Then(@"C Case record be created successfully")]
        public void ThenCCaseRecordBeCreatedSuccessfully()
        {
            TestBase.caseEdit.ClickOnBottomSaveBtn();
            Thread.Sleep(2000);

        }
    }
}
