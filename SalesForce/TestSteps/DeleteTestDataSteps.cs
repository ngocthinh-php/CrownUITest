using SalesForce.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SalesForce.TestSteps
{
    [Binding]
    public sealed class DeleteTestDataSteps
    {
        [Given(@"user is in landing page")]
        public void GivenUserIsInLandingPage()
        {
            TestBase.landing.VerifyPage();
        }

        [Given(@"I am on the Mass Delete Cases Page")]
        public void GivenIAmOnTheMassDeleteCasesPage()
        {
            TestBase.landing.ClickOnCasesTab();
            Thread.Sleep(2000);
            TestBase.cases.VerifyPage();
            Thread.Sleep(2000);
            TestBase.cases.ClickOnMassDeleteCases();
            Thread.Sleep(2000);
            TestBase.caseMassDelete.VerifyPage();
            Thread.Sleep(2000);
        }

        [When(@"I filter the case data (.*), (.*), (.*), (.*), (.*), (.*)")]
        public void WhenIFilterTheCaseData(string column1Row1, string operator1, string value1, string column1Row2, string operator2, string value2)
        {
            TestBase.caseMassDelete.SelectCol1Row1(column1Row1);
            Thread.Sleep(2000);
            TestBase.caseMassDelete.SelectCol2Row1(operator1);
            Thread.Sleep(2000);
            TestBase.caseMassDelete.EnterCol3Row1Data(value1);
            Thread.Sleep(2000);
            TestBase.caseMassDelete.SelectCol1Row2(column1Row2);
            Thread.Sleep(2000);
            TestBase.caseMassDelete.SelectCol2Row2(operator2);
            Thread.Sleep(2000);
            TestBase.caseMassDelete.EnterCol3Row2Data(value2);
            Thread.Sleep(2000);
            TestBase.caseMassDelete.ClickOnSearchButton();
            Thread.Sleep(2000);
            //Count the table data output
            TestBase.caseMassDelete.ReturnTableData();
            Thread.Sleep(2000);
        }


        //[When(@"I filter the data")]
        //public void WhenIFilterTheData(Table table)
        //{
        //    dynamic filters = table.CreateDynamicInstance();
        //    TestBase.caseMassDelete.Col1Row1.SendKeys(filters.lastName);

        //    TestBase.caseMassDelete.Col2Row1.SendKeys(filters.firstName);

        //}

        //[When(@"I filter based on Contact and Customer")]
        //public void WhenIFilterBasedOnContactAndCustomer()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        [When(@"I press Case Delete button")]
        public void WhenIPressCaseDeleteButton()
        {
            TestBase.caseMassDelete.ClickOnSearchOutputHeaderCheckBox();
            Thread.Sleep(2000);
            TestBase.caseMassDelete.ClickOnTopDeleteButton();
            Thread.Sleep(2000);

        }

        [Then(@"all the related case records are deleted")]
        public void ThenAllTheRelatedCaseRecordsAreDeleted()
        {
            TestBase.caseMassDelete.VerifyPage();
            Thread.Sleep(2000);
            TestBase.caseMassDelete.ConfirmDataDeletion();
            Thread.Sleep(2000);
        }

        [Given(@"I am on the Mass Delete Contact Page")]
        public void GivenIAmOnTheMassDeleteContactPage()
        {
            TestBase.landing.ClickOnContactsTab();
            Thread.Sleep(2000);
            TestBase.contacts.VerifyPage();
            Thread.Sleep(2000);
            TestBase.contacts.ClickOnMassDeleteContactsLink();
            Thread.Sleep(2000);
            TestBase.contactMassDelete.VerifyPage();
            Thread.Sleep(2000);
        }

        [When(@"I filter the contact data (.*), (.*), (.*)")]
        public void WhenIFilterTheContactData(string column1Row1, string operator1, string value1)
        {
            TestBase.contactMassDelete.SelectCol1Row1(column1Row1);
            Thread.Sleep(2000);
            TestBase.contactMassDelete.SelectCol2Row1(operator1);
            Thread.Sleep(2000);
            TestBase.contactMassDelete.EnterCol3Row1Data(value1);
            Thread.Sleep(2000);
            TestBase.contactMassDelete.ClickOnSearchButton();
            Thread.Sleep(2000);
            //Count the table data output
            TestBase.contactMassDelete.ReturnTableData();
            Thread.Sleep(2000);

        }

        [When(@"I press Contact Delete button")]
        public void WhenIPressContactDeleteButton()
        {
            TestBase.contactMassDelete.ClickOnSearchOutputHeaderCheckBox();
            Thread.Sleep(2000);
            TestBase.contactMassDelete.ClickOnTopDeleteButton();
            Thread.Sleep(2000);
        }

        [Then(@"all the related contact records are deleted")]
        public void ThenAllTheRelatedContactRecordsAreDeleted()
        {
            TestBase.contactMassDelete.VerifyPage();
            Thread.Sleep(2000);
            TestBase.contactMassDelete.ConfirmDataDeletion();
            Thread.Sleep(2000);
        }

        [Given(@"I am on the Mass Delete Accounts Page")]
        public void GivenIAmOnTheMassDeleteAccountsPage()
        {
            TestBase.landing.ClickOnOrganisationTab();
            Thread.Sleep(2000);
            TestBase.organisations.VerifyPage();
            Thread.Sleep(2000);
            TestBase.organisations.ClickOnMassDeleteOrganisationsLink();
            Thread.Sleep(2000);
            TestBase.orgMassDelete.VerifyPage();
            Thread.Sleep(2000);

        }

        [When(@"I filter the account data (.*), (.*), (.*)")]
        public void WhenIFilterTheAccountData(string column1Row1, string operator1, string value1)
        {
            TestBase.orgMassDelete.SelectCol1Row1(column1Row1);
            Thread.Sleep(2000);
            TestBase.orgMassDelete.SelectCol2Row1(operator1);
            Thread.Sleep(2000);
            TestBase.orgMassDelete.EnterCol3Row1Data(value1);
            Thread.Sleep(2000);
            TestBase.orgMassDelete.ClickOnSearchButton();
            Thread.Sleep(2000);
            //Count the table data output
            TestBase.orgMassDelete.ReturnTableData();
            Thread.Sleep(2000);
        }

        [When(@"I press Organisation Delete button")]
        public void WhenIPressOrganisationDeleteButton()
        {
            TestBase.orgMassDelete.ClickOnSearchOutputHeaderCheckBox();
            Thread.Sleep(2000);
            TestBase.orgMassDelete.ClickOnTopDeleteButton();
            Thread.Sleep(2000);
        }

        [Then(@"all the related Organisation records are deleted")]
        public void ThenAllTheRelatedOrganisationRecordsAreDeleted()
        {
            TestBase.orgMassDelete.VerifyPage();
            Thread.Sleep(2000);
            TestBase.orgMassDelete.ConfirmDataDeletion();
            Thread.Sleep(2000);

        }

    }
}
