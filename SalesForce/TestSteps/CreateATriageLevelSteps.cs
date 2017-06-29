namespace SalesForce.TestSteps
{
    #region Using Directives
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using Hooks;
    #endregion

    [Binding]
    public class CreateATriageLevelSteps
    {
        [Given(@"I am on Triage Level Edit page")]
        public void GivenIAmOnTriageLevelEditPage()
        {
            TestBase.landing.ClickOnAllTabsIcon();
            Thread.Sleep(2000);
            TestBase.alltabs.ClickOnTriageLevelLink();
            Thread.Sleep(2000);
            TestBase.triage.VerifyPage();
            Thread.Sleep(2000);
            TestBase.triage.ClickOnNewButton();
            Thread.Sleep(2000);
            TestBase.triageEdit.VerifyPage();
            Thread.Sleep(2000);
        }

        [When(@"I populate the field values (.*), (.*) , (.*)")]
        public void WhenIPopulateTheFieldValues(string triageLevel, string slaDays, string isDefault)
        {
            TestBase.triageEdit.EnterTriageLevel(triageLevel);
            TestBase.triageEdit.SelectSLADays(slaDays);
            if (isDefault == "Yes")
            {
                TestBase.triageEdit.ClickOnIsDefaultCheckBox();
            }
        }


        //[When(@"I populate the field values")]
        //public void WhenIPopulateTheFieldValues(Table table)
        //{
        //    IEnumerable<dynamic> triageLevel = table.CreateDynamicSet();
        //    foreach (var trgl in triageLevel)
        //    {
        //        TestBase.triageEdit.EnterTriageLevel(trgl.triageLevel);
        //        Thread.Sleep(2000);
        //        Console.WriteLine(trgl.triageLevel);
        //        if (trgl.isDefault == "Yes")
        //        {
        //            TestBase.triageEdit.ClickOnIsDefaultCheckBox();
        //            Thread.Sleep(2000);
        //        }
        //        else
        //        {
        //            TestBase.triageEdit.IsDefaultCheckBox.Clear();
        //        }
        //        Console.WriteLine(trgl.isDefault);
        //        TestBase.triageEdit.SelectSLADays(trgl.slaDays);
        //        Thread.Sleep(2000);
        //        Console.WriteLine(trgl.slaDays);
               
        //    }

        //}

        [When(@"Save the rcord")]
        public void WhenSaveTheRcord()
        {
            TestBase.triageEdit.ClickOnTopSaveButton();
            Thread.Sleep(2000);
        }

        [Then(@"the new (.*) record should be created successfully")]
        public void ThenTheNewRecordShouldBeCreatedSuccessfully(string triageLevel)
        {
            TestBase.triageRecord.VerifyPage();
            Thread.Sleep(2000);
            TestBase.landing.ClickOnAllTabsIcon();
            Thread.Sleep(2000);
            TestBase.alltabs.ClickOnTriageLevelLink();
            Thread.Sleep(2000);
            TestBase.triage.FindTriageLevelDataFromTable(triageLevel);
        }
    }
}
