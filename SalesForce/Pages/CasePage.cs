namespace SalesForce.Pages
{
    #region Using Directives
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using NUnit.Framework;
    using SalesForce.Pages;
    using TechTalk.SpecFlow;
    #endregion

    public class CasePage : BasePage
    {
        #region constructor
        public CasePage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Identify fields
        private By _listCaseView = By.XPath("//*[@id='fcf']");
        private By _btnGo = By.XPath("//*[@id='filter_element']/div/span/span[1]/input");
        private By _lnkEdit = By.XPath("//*[@id='filter_element']/div/span/span[2]/a[1]");
        private By _lnkCreateNewView = By.XPath("//*[@id='filter_element']/div/span/span[2]/a[2]");
        private By _listRecordView = By.XPath("//*[@id='hotlist_mode']");
        private By _lblRecentCases = By.XPath("//*[@id='hotlist']/table/tbody/tr/td[1]/h3");
        private By _tblDataRecentCases = By.XPath("//*[@id='bodyCell']/div[3]/div[1]/div/div[2]");
        private By _btnNewCase = By.XPath("//*[@id='hotlist']/table/tbody/tr/td[2]/input");
        private By _lnkTotalCasesCreated = By.LinkText("Total Cases Created");
        private By _lnkTotalCasesCreatedByAgent = By.LinkText("Total Cases Created by Agent");
        private By _lnkTotalOpenCasesByAgent = By.LinkText("Total Open Cases by Agent");
        private By _lnkContactRoleReport = By.LinkText("Contact Role Report");
        private By _lnkCasesAndEmails = By.LinkText("Cases and Emails");
        private By _lnkCaseHistoryReport = By.LinkText("Case History Report");
        private By _lnkGoToReports = By.LinkText("Go to Reports »");
        private By _lnkMassEmailCases = By.LinkText("Mass Email Cases");
        private By _lnkMassDeleteCases = By.LinkText("Mass Delete Cases");

        #endregion

        #region Properties
        public IWebElement CaseViewList
        {
            get
            {
                return driver.FindElement(_listCaseView);
            }
        }
        public IWebElement GoButton
        {
            get
            {
                return driver.FindElement(_btnGo);
            }
        }
        public IWebElement EditLink
        {
            get
            {
                return driver.FindElement(_lnkEdit);
            }
        }
        public IWebElement CreateNewViewLink
        {
            get
            {
                return driver.FindElement(_lnkCreateNewView);
            }
        }
        public IWebElement RecordViewList
        {
            get
            {
                return driver.FindElement(_listRecordView);
            }
        }
        public IWebElement RecentCasesTable
        {
            get
            {
                return driver.FindElement(_tblDataRecentCases);
            }
        }
        public IWebElement RecentCasesLabel
        {
            get
            {
                return driver.FindElement(_lblRecentCases);
            }
        }
        public IWebElement TotalCasesCreated
        {
            get
            {
                return driver.FindElement(_lnkTotalCasesCreated);
            }
        }
        public IWebElement TotalCasesCreatedByAgent
        {
            get
            {
                return driver.FindElement(_lnkTotalCasesCreatedByAgent);
            }
        }
        public IWebElement TotalOpenCasesByAgent
        {
            get
            {
                return driver.FindElement(_lnkTotalOpenCasesByAgent);
            }
        }
        public IWebElement ContactRoleReport
        {
            get
            {
                return driver.FindElement(_lnkContactRoleReport);
            }
        }
        public IWebElement CasesAndEmails
        {
            get
            {
                return driver.FindElement(_lnkCasesAndEmails);
            }
        }
        public IWebElement CaseHistoryReport
        {
            get
            {
                return driver.FindElement(_lnkCaseHistoryReport);
            }
        }
        public IWebElement GoToReports
        {
            get
            {
                return driver.FindElement(_lnkGoToReports);
            }
        }
        public IWebElement MassEmailCases
        {
            get
            {
                return driver.FindElement(_lnkMassEmailCases);
            }
        }
        public IWebElement MassDeleteCases
        {
            get
            {
                return driver.FindElement(_lnkMassDeleteCases);
            }
        }
        public IWebElement NewCase
        {
            get
            {
                return driver.FindElement(_btnNewCase);
            }
        }
        #endregion

        #region Public methods
        public void VerifyPage()
        {
            Assert.AreEqual("Cases: Home ~ Salesforce - Enterprise Edition", driver.Title);
        }
        public void SelectAllProfileCaseView(string profilecaseView)
        {
            if (CaseViewList.Displayed)
            {
                CaseViewList.Click();
                var x1 = "//*[contains(text(),'";
                var x2 = profilecaseView;
                var x3 = "')]";
                Thread.Sleep(3000);
                driver.FindElement(By.XPath(x1 + x2 + x3)).Click();

            }
            else
            {
                throw new Exception("Case View could not be selected");
            }
        }
        public void ClickOnCaseViewGoButton()
        {
            if (GoButton.Displayed)
            {
                GoButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnEditLink()
        {
            if (EditLink.Displayed)
            {
                EditLink.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnCreateNewViewLink()
        {
            if (CreateNewViewLink.Displayed)
            {
                CreateNewViewLink.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void SelectYourView(string caseView)
        {
            if (RecordViewList.Displayed)
            {
                RecordViewList.Click();
                var x1 = "//*[contains(text(),'";
                var x2 = caseView;
                var x3 = "')]";
                Thread.Sleep(3000);
                driver.FindElement(By.XPath(x1 + x2 + x3)).Click();

            }
            else
            {
                throw new Exception("organisation name could not be selected");
            }
        }

        public void ClickOnTotalCasesCreated()
        {
            if (TotalCasesCreated.Displayed)
            {
                TotalCasesCreated.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnTotalCasesCreatedByAgent()
        {
            if (TotalCasesCreatedByAgent.Displayed)
            {
                TotalCasesCreatedByAgent.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnContactRoleReport()
        {
            if (ContactRoleReport.Displayed)
            {
                ContactRoleReport.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnCasesAndEmails()
        {
            if (CasesAndEmails.Displayed)
            {
                CasesAndEmails.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnCaseHistoryReport()
        {
            if (CaseHistoryReport.Displayed)
            {
                CaseHistoryReport.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnGoToReports()
        {
            if (GoToReports.Displayed)
            {
                GoToReports.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnMassEmailCases()
        {
            if (MassEmailCases.Displayed)
            {
                MassEmailCases.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnMassDeleteCases()
        {
            if (MassDeleteCases.Displayed)
            {
                MassDeleteCases.Click();
            }
            else
            {
                Exception e;
            }
        }
        /// <summary>
        /// Find Sepecific Case data from the table and Click on it
        /// </summary>
        /// <param name="caseDetl"></param>
        public void FindCaseDataFromTable(string caseDetl)
        {
            if (caseDetl != null)
            {             
                var x2 = caseDetl;
                var x1 = "//*[contains(text(),'";
                var x3 = "')]";
                Thread.Sleep(3000);
                driver.FindElement(By.XPath(x1 + x2 + x3)).Click();

            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void RecentCasesTableExists()
        {
            Assert.IsTrue(RecentCasesLabel.Displayed);
            //Assert.AreEqual("Recent Cases", driver.FindElement(_lblRecentCases));
        }
        public void ClickOnNewButton()
        {
            if (NewCase.Displayed)
            {
                NewCase.Click();
            }
            else
            {
                Exception e;
            }
        }

        /// <summary>
        /// get all of the recent case table data
        /// </summary>
        public void ReturnTableData()
        {
            // xpath of html table
            var elemTable = driver.FindElement(_tblDataRecentCases);

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
        #endregion
    }
}
