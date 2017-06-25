using NUnit.Framework;
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
    public sealed class CreateACategorySteps
    {
        [Given(@"I am on Category page")]
        public void GivenIAmOnCategoryPage()
        {
            TestBase.landing.ClickOnAllTabsIcon();
            Thread.Sleep(2000);
            TestBase.landing.ClickOnCategoriesLink();
            Thread.Sleep(2000);
            TestBase.category.VerifyPage();
            Thread.Sleep(2000);
        }

        [When(@"I click on New Category button")]
        public void WhenIClickOnNewCategoryButton()
        {
            TestBase.category.ClickOnNewButton();
            Thread.Sleep(2000);
        }

        [Then(@"I should be navigated to Category Edit page")]
        public void ThenIShouldBeNavigatedToCategoryEditPage()
        {
            TestBase.catEdit.VerifyPage();
            Thread.Sleep(2000);
        }

        [When(@"I enter category details (.*), (.*), (.*), (.*), (.*), (.*), (.*) and Save the record")]
        public void WhenIEnterCategoryDetailsAndSaveTheRecord(string catName, string catCode, string catType, string parent, string catExtId, string parentName, string pgDescription)
        {
            TestBase.catEdit.EnterCategoryName(catName);
            TestBase.catEdit.EnterCategoryCode(catCode);
            TestBase.catEdit.SelectCategoryType(catType);
            TestBase.catEdit.EnterParent(parent);
            //TestBase.catEdit.SelectCodeType(codeType);
            //Thread.Sleep(2000);
            TestBase.catEdit.EnterCatExternalId(catExtId);
            TestBase.catEdit.EnterParentName(parentName);
            TestBase.catEdit.EnterPGDescription(pgDescription);
            TestBase.catEdit.ClickOnTopSaveButton(); 
    }


        //[When(@"I enter category details and Save the record")]
        //public void WhenIEnterCategoryDetailsAndSaveTheRecord(Table table)
        //{
        //    dynamic T = table.CreateDynamicInstance();
        //    T.catName


        //    TestBase.catEdit.ClickOnTopSaveButton();
        //    Thread.Sleep(2000);
        //}

        [Then(@"a Category record is created successfully")]
        public void ThenACategoryRecordIsCreatedSuccessfully()
        {
            TestBase.catRecord.VerifyPage();
            Console.WriteLine("Record Created Successfully");
        }

    }
}
