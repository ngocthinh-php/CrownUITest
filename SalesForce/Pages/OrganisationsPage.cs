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

    public class OrganisationsPage : BasePage
    {
        #region constructor
        public OrganisationsPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Properties and fields
        private By _listViewOrganisations = By.XPath("//*[@id='fcf']");
        private By _btnGo = By.XPath("//*[@id='filter_element']/div/span/span[1]/input");
        private By _linkEdit = By.LinkText("Edit");
        private By _linkCreateNewView = By.LinkText("Create New View");
        private By _frameRecentOrganisations = By.XPath("//*[@id='bodyCell']/div[3]/div[1]/div");
        private By _lblRecentOrganisations = By.XPath("//*[@id='hotlist']/table/tbody/tr/td[1]/h3");
        private By _btnNew = By.XPath("//*[@id='hotlist']/table/tbody/tr/td[2]/input");
        private By _listRecentItem = By.XPath("//*[@id='hotlist_mode']");
        private By _frameReports = By.XPath("//*[@id='toolsContent']/tbody/tr/td[1]/div/div");
        private By _frameTools = By.XPath("//*[@id='toolsContent']/tbody/tr/td[2]/div/div");

        private By _linkActiveOrganisations = By.LinkText("Active Organisations");
        private By _linkOrganisationsWithLastActivity = By.PartialLinkText("Organisations with last activity");
        private By _linkAccountManagers = By.LinkText("Account Managers");
        private By _linkContactRoleReport = By.LinkText("Contact Role Report");
        private By _linkOrganisationHistoryReport = By.LinkText("Organisation History Report");
        private By _linkPartnerAccounts = By.LinkText("Partner Accounts");
        private By _linkGoToReports = By.PartialLinkText("Go to Reports");
        private By _linkImportOrganisationsAndContacts = By.LinkText("Import Organisations & Contacts");
        private By _linkMassDeleteOrganisations = By.LinkText("Mass Delete Organisations");
        private By _linkTransferOrganisations = By.LinkText("Transfer Organisations");
        private By _linkMergeOrganisations = By.LinkText("Merge Organisations");
        private By _linkSalesMethodologies = By.LinkText("Sales Methodologies");


        public IWebElement RecentOrganisationFrame
        {
            get
            {
                return driver.FindElement(_frameRecentOrganisations);
            }
        }
        public IWebElement RecentOrganisationsLabel
        {
            get
            {
                return driver.FindElement(_lblRecentOrganisations);
            }
        }
        public IWebElement NewOrganisationBtn
        {
            get
            {
                return driver.FindElement(_btnNew);
            }
        }
        public IWebElement RecentItemList
        {
            get
            {
                return driver.FindElement(_listRecentItem);
            }
        }
        public IWebElement ReportsFrame
        {
            get
            {
                return driver.FindElement(_frameReports);
            }
        }
        public IWebElement ToolsFrame
        {
            get
            {
                return driver.FindElement(_frameTools);
            }
        }

        public IWebElement ActiveOrganisations
        {
            get
            {
                return driver.FindElement(_linkActiveOrganisations);
            }
        }
        public IWebElement OrganisationsWithLastActivity
        {
            get
            {
                return driver.FindElement(_linkOrganisationsWithLastActivity);
            }
        }
        public IWebElement AccountManagers
        {
            get
            {
                return driver.FindElement(_linkAccountManagers);
            }
        }
        public IWebElement ContactRoleReport
        {
            get
            {
                return driver.FindElement(_linkContactRoleReport);
            }
        }
        public IWebElement OrganisationHistoryReport
        {
            get
            {
                return driver.FindElement(_linkOrganisationHistoryReport);
            }
        }
        public IWebElement PartnerAccounts
        {
            get
            {
                return driver.FindElement(_linkPartnerAccounts);
            }
        }
        public IWebElement GoToReports
        {
            get
            {
                return driver.FindElement(_linkGoToReports);
            }
        }
        public IWebElement ImportOrganisationsAndContacts
        {
            get
            {
                return driver.FindElement(_linkImportOrganisationsAndContacts);
            }
        }
        public IWebElement MassDeleteOrganisations
        {
            get
            {
                return driver.FindElement(_linkMassDeleteOrganisations);
            }
        }
        public IWebElement TransferOrganisations
        {
            get
            {
                return driver.FindElement(_linkTransferOrganisations);
            }
        }
        public IWebElement MergeOrganisations
        {
            get
            {
                return driver.FindElement(_linkMergeOrganisations);
            }
        }
        public IWebElement SalesMethodologies
        {
            get
            {
                return driver.FindElement(_linkSalesMethodologies);
            }
        }
        #endregion

        #region Public methods
        public void VerifyPage()
        {
            Assert.AreEqual("Organisations: Home ~ Salesforce - Enterprise Edition", driver.Title);
            Assert.IsTrue(RecentOrganisationFrame.Displayed);
            Assert.IsTrue(NewOrganisationBtn.Displayed);
            Assert.IsTrue(RecentOrganisationsLabel.Displayed);
            Assert.IsTrue(RecentItemList.Displayed);
            Assert.IsTrue(ReportsFrame.Displayed);
            Assert.IsTrue(ToolsFrame.Displayed);
        }

        public void ClickOnNewOrganisationBtn()
        {
            if (NewOrganisationBtn.Displayed)
            {
                NewOrganisationBtn.Click();
                Thread.Sleep(5000);
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnActiveOrganisationsLink()
        {
            if (ActiveOrganisations.Displayed)
            {
                ActiveOrganisations.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnOrganisationsWithLastActivityLink()
        {
            if (OrganisationsWithLastActivity.Displayed)
            {
                OrganisationsWithLastActivity.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }        
        }
        public void ClickOnAccountManagersLink()
        {
            if (AccountManagers.Displayed)
            {
                AccountManagers.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnContactRoleReportLink()
        {
            if (ContactRoleReport.Displayed)
            {
                ContactRoleReport.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnOrganisationHistoryReportLink()
        {
            if (OrganisationHistoryReport.Displayed)
            {
                OrganisationHistoryReport.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnPartnerAccountsLink()
        {
            if (PartnerAccounts.Displayed)
            {
                PartnerAccounts.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnGoToReportsLink()
        {
            if (GoToReports.Displayed)
            {
                GoToReports.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnImportOrganisationsAndContactsLink()
        {
            if (ImportOrganisationsAndContacts.Displayed)
            {
                ImportOrganisationsAndContacts.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnMassDeleteOrganisationsLink()
        {
            if (MassDeleteOrganisations.Displayed)
            {
                MassDeleteOrganisations.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnTransferOrganisationsLink()
        {
            if (TransferOrganisations.Displayed)
            {
                TransferOrganisations.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnMergeOrganisationsLink()
        {
            if (MergeOrganisations.Displayed)
            {
                MergeOrganisations.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnSalesMethodologiesLink()
        {
            if (SalesMethodologies.Displayed)
            {
                SalesMethodologies.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        #endregion
    }
}
