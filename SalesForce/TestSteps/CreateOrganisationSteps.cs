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
        [Given(@"I am on Select New Organisation Record Type page")]
        public void GivenIAmOnSelectNewOrganisationRecordTypePage()
        {
            TestBase.landing.ClickOnOrganisationTab();
            Thread.Sleep(2000);
            TestBase.organisations.VerifyPage();
            Thread.Sleep(2000);
            TestBase.organisations.ClickOnNewOrganisationBtn();
            Thread.Sleep(2000);
            TestBase.newOrg.VerifyPage();
        }
        [When(@"I Select Organisation Record Type as (.*)")]
        public void WhenISelectOrganisationRecordTypeAs(string organisation)
        {
            TestBase.newOrg.SelectOrganisationType(organisation);
            //TestBase.newOrg.selectList(organisation);
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
        [When(@"click on Save button")]
        public void WhenClickOnSaveButton()
        {
            TestBase.orgEdit.ClickTopSaveBtn();
        }

        [Then(@"a new organisation (.*) would be created")]
        public void ThenANewOrganisationWouldBeCreated(string organisationName)
        {
            TestBase.orgRecord.VerifyPage(organisationName);
            Thread.Sleep(3000);
           
        }
    }
}
