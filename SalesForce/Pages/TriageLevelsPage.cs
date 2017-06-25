namespace SalesForce.Pages
{
    #region Using Directives
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    using OpenQA.Selenium.Support.UI;
    #endregion

    public class TriageLevelsPage : BasePage
    {
        #region constructor
        public TriageLevelsPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Properties and fields
        private By _listPageView = By.XPath("//*[@id='fcf']");
        private By _btnGo = By.XPath("//*[@id='filter_element']/div/span/span[1]/input");
        private By _tableTriageLevelData = By.XPath("//*[@id='bodyCell']/div[3]/div[1]/div/div[2]/table");
        private By _btnNew = By.XPath("//*[@id=hotlist']/table/tbody/tr/td[2]/input");
        private By _lablelNoRecordInTable = By.XPath("//*[@id='bodyCell']/div[3]/div[1]/div/div[2]/table/tbody/tr/th");

        public IWebElement PageView
        {
            get
            {
                return driver.FindElement(_listPageView);
            }
        }
        public IWebElement GoButton
        {
            get
            {
                return driver.FindElement(_btnGo);
            }
        }
        public IWebElement TriageLevelDataTable
        {
            get
            {
                return driver.FindElement(_tableTriageLevelData);
            }
        }
        public IWebElement NewButton
        {
            get
            {
                return driver.FindElement(_btnNew);
            }
        }
        public IWebElement NoRecordInTableMessage
        {
            get
            {
                return driver.FindElement(_lablelNoRecordInTable);
            }
        }
        #endregion

        #region Public methods
        public void VerifyPage()
        {
            Assert.AreEqual("Triage Levels: Home ~ Salesforce - Enterprise Edition", driver.Title);
        }
        public void ClickOnGoButton()
        {
            if (GoButton.Displayed)
            {
                GoButton.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnNewButton()
        {
            if (NewButton.Displayed)
            {
                NewButton.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void SelectPageViewList(string viewItem)
        {
            if (PageView.Displayed)
            {
                IWebElement dropDownListBox = PageView;
                SelectElement clickThis = new SelectElement(dropDownListBox);
                clickThis.SelectByText(viewItem);
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ReturnTableData()
        {
            // xpath of html table
            var elemTable = driver.FindElement(_tableTriageLevelData);
            //var elemTable = driver.FindElement(_tablePageView);
            // Fetch all Row of the table
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            String strRowData = "";

            // Traverse each row
            foreach (var elemTr in lstTrElem)
            {
                // Fetch the columns from a particuler row
                List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                if (lstTdElem.Count > 0)
                {
                    // Traverse each column
                    foreach (var elemTd in lstTdElem)
                    {
                        // "\t\t" is used for Tab Space between two Text
                        strRowData = strRowData + elemTd.Text + "\t\t";
                    }
                }
                else
                {
                    // To print the data into the console
                    Console.WriteLine("Data Retrieved");
                    //Console.WriteLine(lstTrElem[0].Text.Replace(" ", "\t\t"));
                }
                //Console.WriteLine(strRowData);
                strRowData = String.Empty;
            }
            //Console.WriteLine("");

            //Assert.IsTrue(CaseSubjectName.Displayed );

        }
        public void FindCategoriesDataFromTable(string triageLevel)
        {
            if (triageLevel != null)
            {
                var x2 = triageLevel;
                var x1 = "//a[contains(text(),'";
                var x3 = "')]";
                Thread.Sleep(2000);
                driver.FindElement(By.XPath(x1 + x2 + x3)).Click();

            }
            else
            {
                Assert.AreEqual("No recent records. Click Go or select a view from the dropdown to display records.", NoRecordInTableMessage.Text);
            }
        }
        #endregion
    }
}
