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

    public class CategoriesPage : BasePage
    {
        #region Constructor
        public CategoriesPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Properties and fields
        private By _tableRecentCategories = By.XPath("//*[@id='bodyCell']/div[3]/div[1]/div/div[2]/table");
        private By _tablePageView = By.CssSelector("div#ext-gen10.x-grid3-scroller");
        private By _btnNew = By.XPath("//*[@id='hotlist']/table/tbody/tr/td[2]/input");
        //private By _listPageView = By.XPath("//*[@id='fcf']");
        private By _listPageView = By.XPath("//span[text()='Test Marketing']");
        private By _btnGo = By.XPath("//*[@id='filter_element']/div/span/span[1]/input");
        private By _listRecentCategoryView = By.XPath("//*[@id='hotlist_mode']");
        private By _labelNoRecordFoundRecentView = By.CssSelector("th.noRowsHeader");
        private By _labelNoRecordFoundViewOutput = By.XPath("//*[@id='ext-gen11']/div");


        public IWebElement NoRecordFoundViewOutput
        {
            get
            {
                return driver.FindElement(_labelNoRecordFoundViewOutput);
            }
        }
        public IWebElement RecentCategoriesTable
        {
            get
            {
                return driver.FindElement(_tableRecentCategories);
            }
        }
        public IWebElement NewButton
        {
            get
            {
                return driver.FindElement(_btnNew);
            }
        }
        public IWebElement GoButton
        {
            get
            {
                return driver.FindElement(_btnGo);
            }
        }
        public IWebElement PageViewList
        {
            get
            {
                return driver.FindElement(_listPageView);
            }
        }
        public IWebElement RecentCategoryViewList
        {
            get
            {
                return driver.FindElement(_listRecentCategoryView);
            }
        }
        public IWebElement NoRecordFound
        {
            get
            {
                return driver.FindElement(_labelNoRecordFoundRecentView);
            }
        }

        #endregion

        #region Public methods
        public void VerifyPage()
        {
            Assert.AreEqual("Categories: Home ~ Salesforce - Enterprise Edition", driver.Title);
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
        public void SelectView(string cView)
        {
            if (cView != null)
            {       
                IWebElement dropDownListBox = PageViewList;
                SelectElement clickThis = new SelectElement(dropDownListBox);
                clickThis.SelectByText(cView);      
            }
            else
            {
                Assert.AreEqual("No records to display.", NoRecordFoundViewOutput.Text);

            }
        }
        public void SelectRecentCategoryView(string recentCatView)
        {
            if (RecentCategoryViewList.Displayed)
            {
                IWebElement dropDownListBox = RecentCategoryViewList;
                SelectElement clickThis = new SelectElement(dropDownListBox);
                clickThis.SelectByText(recentCatView);
            }
            else
            {
                Assert.AreEqual("No recent records. Click Go or select a view from the dropdown to display records.", NoRecordFound.Text);
            }
        }
        

        /// <summary>
        /// get all of the categories table data
        /// </summary>
        public void ReturnTableData()
        {
            // xpath of html table
            var elemTable = driver.FindElement(_tableRecentCategories);
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
                Console.WriteLine(strRowData);
                strRowData = String.Empty;
            }
            Console.WriteLine("");

            //Assert.IsTrue(CaseSubjectName.Displayed );

        }
        public void FindCategoriesDataFromTable(string categoryDetl)
        {
            if (categoryDetl != null)
            {
                var x2 = categoryDetl;
                var x1 = "//a[contains(text(),'";
                //var x1 = "//span[contains(text(),'";
                var x3 = "')]";
                Thread.Sleep(2000);
                driver.FindElement(By.XPath(x1 + x2 + x3)).Click();

            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        #endregion
    }
}
