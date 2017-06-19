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
    public sealed class RecentCasesSteps
    {
        //[Given(@"I am on Cases page")]
        //public void GivenIAmOnCasesPage()
        //{
        //    TestBase.landing.ClickOnCasesTab();
        //    Thread.Sleep(2000);
        //    TestBase.cases.VerifyPage();
        //    Thread.Sleep(2000);
        //}

        [When(@"I go to Recent Cases section")]
        public void WhenIGoToRecentCasesSection()
        {
            TestBase.cases.RecentCasesTableExists();
            Thread.Sleep(3000);
        }

        [Then(@"I should be able to retrieve all the table data")]
        public void ThenIShouldBeAbleToRetrieveAllTheTableData()
        {
            TestBase.cases.ReturnTableData();
        }

        [Then(@"can click on (.*)")]
        public void ThenCanClickOn(string caseSubject)
        {
            TestBase.cases.FindCaseDataFromTable(caseSubject);
        }


    }
}
