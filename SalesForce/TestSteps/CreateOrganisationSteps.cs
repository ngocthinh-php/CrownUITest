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
    public sealed class CreateOrganisationSteps
    {
        [Given(@"I am on Organisation Home Page")]
        public void GivenIAmOnOrganisationHomePage()
        {
            TestBase.login.UserLogin("chitta.jena@crowncommercial.gov.uk.pemqa", "Data@3456");
            Thread.Sleep(5000);
            TestBase.login.ClickOnLogIn();
            Thread.Sleep(5000);
            TestBase.landing.ClickOnOrganisationTab();
            Thread.Sleep(3000);
            TestBase.organisations.VerifyPage();
        }

        [When(@"I click on New button")]
        public void WhenIClickOnNewButton()
        {
            TestBase.organisations.ClickOnNewOrganisationBtn();
        }

        [Then(@"I should be directed to Select New Organisation Record Type page")]
        public void ThenIShouldBeDirectedToSelectNewOrganisationRecordTypePage()
        {
            TestBase.newOrg.VerifyPage();
        }
        [When(@"I Select Organisation Record Type as (.*)")]
        public void WhenISelectOrganisationRecordTypeAs(string organisation)
        {
            TestBase.newOrg.SelectOrganisationType(organisation);
        }

        [When(@"Click on Continue button")]
        public void WhenClickOnContinueButton()
        {
            TestBase.newOrg.ClickOnContinueButton();
        }

        [Then(@"I should be presented with organisation Edit Page")]
        public void ThenIShouldBePresentedWithOrganisationEditPage()
        {
            TestBase.orgEdit.VerifyPage();
        }

        [When(@"I enter mandatory information for customer (.*), (.*), (.*), (.*)")]
        public void WhenIEnterMandatoryInformationForCustomer(string organisationName, string sector, string organisationType, string status)
        {
            TestBase.orgEdit.EnterOrganisationName(organisationName);
            Thread.Sleep(3000);
            TestBase.orgEdit.SelectASector(sector);
            Thread.Sleep(3000);
            TestBase.orgEdit.SelectOrganisationType(organisationType);
            Thread.Sleep(3000);
            TestBase.orgEdit.SelectStatus(status);
            Thread.Sleep(3000); 
        }
        [When(@"I enter mandatory information for supplier(.*), (.*), (.*)")]
        public void WhenIEnterMandatoryInformationForSupplier(string organisationName, string sector, string organisationType)
        {
            TestBase.orgEdit.EnterOrganisationName(organisationName);
            Thread.Sleep(3000);
            TestBase.orgEdit.SelectASector(sector);
            Thread.Sleep(3000);
            TestBase.orgEdit.SelectOrganisationType(organisationType);
            Thread.Sleep(3000);
         }
        //[When(@"I enter mandatory information Customer(.*) and select Local Government and select Active")]
        //public void WhenIEnterMandatoryInformationCustomerAndSelectLocalGovernmentAndSelectActive(int p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[Then(@"I Should be presented with organisation type drop down")]
        //public void ThenIShouldBePresentedWithOrganisationTypeDropDown()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[When(@"I select a value from County Council drop down field")]
        //public void WhenISelectAValueFromCountyCouncilDropDownField()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        [When(@"click on Save button")]
        public void WhenClickOnSaveButton()
        {
            TestBase.orgEdit.ClickTopSaveBtn();
        }

        [Then(@"a new organisation (.*) would be created")]
        public void ThenANewOrganisationWouldBeCreated(string organisationName)
        {
            TestBase.orgRecord.VerifyPage(organisationName);
        }

        //[When(@"I Select Organisation Record Type as Customer")]
        //public void WhenISelectOrganisationRecordTypeAsCustomer()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[When(@"I enter mandatory information Supplier(.*) and select Public Sector")]
        //public void WhenIEnterMandatoryInformationSupplierAndSelectPublicSector(int p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[When(@"I select a value from Health drop down field")]
        //public void WhenISelectAValueFromHealthDropDownField()
        //{
        //    ScenarioContext.Current.Pending();
        //}

    }
}
