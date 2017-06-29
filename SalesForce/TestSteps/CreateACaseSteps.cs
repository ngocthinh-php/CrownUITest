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

        [When(@"I select case Type as (.*) and continue")]
        public void WhenISelectCaseTypeAsAndContinue(string caseType)
        {
            TestBase.newCase.SelectCaseType(caseType);
            //Thread.Sleep(2000);
            TestBase.newCase.ClickOnContinueButton();
            //Thread.Sleep(2000);
        }

        [Then(@"I should be presented with Case Edit screen")]
        public void ThenIShouldBePresentedWithCaseEditScreen()
        {
            TestBase.caseEdit.VerifyPage();
            //Thread.Sleep(2000);
        }

        [When(@"I populate mandatory Enquiry case information (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) for the case and Save the record")]
        public void WhenIPopulateMandatoryEnquiryCaseInformationForTheCaseAndSaveTheRecord(string orgName, string contactName, string team, string status, string priority, string triageLevel, string caseOrigin, string caseSubject, string description)
        {
            TestBase.caseEdit.EnterOrganisationName(orgName);
            Thread.Sleep(2000);
            TestBase.caseEdit.EnterContactName(contactName);
            Thread.Sleep(2000);
            TestBase.caseEdit.SelectATeam(team);
            Thread.Sleep(2000);
            TestBase.caseEdit.SelectCaseStatus(status);
            Thread.Sleep(2000);
            TestBase.caseEdit.SelectCasePriority(priority);
            Thread.Sleep(2000);
            TestBase.caseEdit.EnterTriageLevel(triageLevel);
            Thread.Sleep(2000);
            TestBase.caseEdit.SelectCaseOrigin(caseOrigin);
            Thread.Sleep(2000);
            TestBase.caseEdit.EnterCaseSubject(caseSubject);
            Thread.Sleep(2000);
            TestBase.caseEdit.EnterCaseDescription(description);
            Thread.Sleep(2000);
            TestBase.caseEdit.ClickOnBottomSaveBtn();
            Thread.Sleep(2000);
            //TestBase.caseEdit.CreateEnquiryCase(orgName, contactName, team, status, priority, triageLevel, caseOrigin, subject, description);
        }

        [When(@"I populate mandatory Tech Support Case information (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) for the case and Save the record")]
        public void WhenIPopulateMandatoryTechSupportCaseInformationForTheCaseAndSaveTheRecord(string contactName, string orgName, string technologyTeam, string caseOrigin, string workflow, string category, string status, string priority, string supportClassification, string subject, string description)
        {
            TestBase.caseEdit.EnterContactName(contactName);
            Thread.Sleep(2000);
            TestBase.caseEdit.EnterOrganisationName(orgName);
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
            //TestBase.caseEdit.SelectSCLevel1(SCLevel1);
            //Thread.Sleep(2000);
            //TestBase.caseEdit.SelectSCLevel2(SCLevel2);
            //Thread.Sleep(2000);
            TestBase.caseEdit.EnterCaseSubject(subject);
            Thread.Sleep(2000);
            TestBase.caseEdit.EnterCaseDescription(description);
            Thread.Sleep(2000);
            TestBase.caseEdit.ClickOnBottomSaveBtn();
            Thread.Sleep(2000);
            //TestBase.caseEdit.CreateTechSupportCase(orgName, contactName, technologyTeam, caseOrigin, workflow, category, status, priority, supportClassification, SCLevel1, SCLevel2, subject, description);
        }

        [When(@"I populate mandatory Procurement Case information (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) for the case and Save the record")]
        public void WhenIPopulateMandatoryProcurementCaseInformationCustomerTestInProgressBelowKImportantBasicBuyingTeamTestMarketingEmailTestProcurementTestProcurementNoNoYesNoNoGreenForTheCaseAndSaveTheRecord(string orgName, string procReference, string status, string value, string straImpToCustomer, string sourComplexity, string ccsTeam, string CASCategory, string caseOrigin, string subject, string description, string coErgAppReqlist, string dwpCARList, string olncAppReqList, string modrcaAppReqList, string dwpmcatAppReqList, string priority)
        {
            TestBase.caseEdit.EnterOrgNameTxt(orgName);
            TestBase.caseEdit.EnterProcReferenceTxt(procReference);
            TestBase.caseEdit.SelectProcStatusList(status);
            TestBase.caseEdit.SelectProcValueList(value);
            TestBase.caseEdit.SelectStraImpToCustomerList(straImpToCustomer);
            TestBase.caseEdit.SelectSourComplexityList(sourComplexity);
            TestBase.caseEdit.SelectCcsTeamList(ccsTeam);
            TestBase.caseEdit.EnterProcCASCategoryTxt(CASCategory);
            TestBase.caseEdit.SelectProcCaseOriginList(caseOrigin);
            TestBase.caseEdit.EnterProcSubjectTxt(subject);
            TestBase.caseEdit.EnterProcDescriptionTxt(description);
            TestBase.caseEdit.SelectDwpCARList(dwpCARList);
            TestBase.caseEdit.SelectOlncAppReqList(olncAppReqList);
            TestBase.caseEdit.SelectModrcaAppReqList(modrcaAppReqList);
            TestBase.caseEdit.SelectDwpmcatAppReqList(dwpmcatAppReqList);
            TestBase.caseEdit.SelectProcPriorityList(priority);
            TestBase.caseEdit.ClickOnTopSaveBtn();
        }


        [Then(@"a Case record be created successfully")]
        public void ThenACaseRecordBeCreatedSuccessfully()
        {
            TestBase.caseRecord.VerifyPage();
        }
    }
}
