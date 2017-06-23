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

    public class ContactsPage : BasePage
    {
        #region constructor
        public ContactsPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Identify fields 
        private By _listContactView = By.XPath("//*[@id='fcf']");
        private By _btnGo = By.XPath("//*[@id='filter_element']/div/span/span[1]/input");
        private By _linkEdit = By.XPath("//*[@id='filter_element']/div/span/span[2]/a[1]");
        private By _linkCreateNewView = By.XPath("//*[@id='filter_element']/div/span/span[2]/a[2]");
        private By _frameRecentContacts = By.XPath("//*[@id='bodyCell']/div[3]/div[1]/div");
        private By _tableRecentContacts = By.XPath("//*[@id='bodyCell']/div[3]/div[1]/div/div[2]/table");
        private By _btnNew = By.XPath("//*[@id='hotlist']/table/tbody/tr/td[2]/input");
        private By _listRecentContactView = By.XPath("//*[@id='hotlist_mode']");
        private By _linkHTMLEmailStatusReport = By.LinkText("HTML Email Status Report");
        private By _linkPartnerAccounts = By.LinkText("Partner Accounts");
        private By _linkMailingList = By.LinkText("Mailing List");
        private By _LinkContactHistoryReport = By.LinkText("Contact History Report");
        private By _linkBouncedContacts = By.LinkText("Bounced Contacts");
        private By _linkGoToReports = By.PartialLinkText("Go to Reports");
        private By _linkSyncToOutlook = By.LinkText("Sync to Outlook");
        private By _linkImportOrganisationsNContacts = By.LinkText("Import Organisations & Contacts");
        private By _linkMassDeleteContacts = By.LinkText("Mass Delete Contacts");
        private By _linkMassEmailContacts = By.LinkText("Mass Email Contacts");
        #endregion

        #region Properties
        public IWebElement ContactDataProfileView
        {
            get
            {
                return driver.FindElement(_listContactView);
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
                return driver.FindElement(_linkEdit);
            }
        }
        public IWebElement CreateNewViewLink
        {
            get
            {
                return driver.FindElement(_linkCreateNewView);
            }
        }
        public IWebElement RecentContactsFrame
        {
            get
            {
                return driver.FindElement(_frameRecentContacts);
            }
        }
        public IWebElement RecentContactsTableData
        {
            get
            {
                return driver.FindElement(_tableRecentContacts);
            }
        }
        public IWebElement NewButton
        {
            get
            {
                return driver.FindElement(_btnNew);
            }
        }
        public IWebElement RecentContactView
        {
            get
            {
                return driver.FindElement(_listRecentContactView);
            }
        }
        public IWebElement HTMLEmailStatusReportlink
        {
            get
            {
                return driver.FindElement(_linkHTMLEmailStatusReport);
            }
        }
        public IWebElement PartnerAccountsLink
        {
            get
            {
                return driver.FindElement(_linkPartnerAccounts);
            }
        }
        public IWebElement MailingListLink
        {
            get
            {
                return driver.FindElement(_linkMailingList);
            }
        }
        public IWebElement ContactHistoryReportLink
        {
            get
            {
                return driver.FindElement(_LinkContactHistoryReport);
            }
        }
        public IWebElement BouncedContactsLink
        {
            get
            {
                return driver.FindElement(_linkBouncedContacts);
            }
        }
        public IWebElement GoToReportsLink
        {
            get
            {
                return driver.FindElement(_linkGoToReports);
            }
        }
        public IWebElement SyncToOutlookLink
        {
            get
            {
                return driver.FindElement(_linkSyncToOutlook);
            }
        }
        public IWebElement ImportOrganisationsNContactsLink
        {
            get
            {
                return driver.FindElement(_linkImportOrganisationsNContacts);
            }
        }
        public IWebElement MassDeleteContactsLink
        {
            get
            {
                return driver.FindElement(_linkMassDeleteContacts);
            }
        }
        public IWebElement MassEmailContactsLink
        {
            get
            {
                return driver.FindElement(_linkMassEmailContacts);
            }
        }

        #endregion

        #region Public methods
        public void VerifyPage()
        {
            Assert.AreEqual("Contacts: Home ~ Salesforce - Enterprise Edition", driver.Title);
        }

        public void SelectContactDataViewForThisProfile(string profileContactView)
        {
            if (profileContactView != null)
            {
                var x2 = profileContactView;
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
        public void ClickOnGoButton()
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
                throw new Exception("Element is not found or not clickable");
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
                throw new Exception("Element is not found or not clickable");
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
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void SelectRecentContactView(string recentContactView)
        {
            if (recentContactView != null)
            {
                var x2 = recentContactView;
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
        public void ClickOnHTMLEmailStatusReportlink()
        {
            if (HTMLEmailStatusReportlink.Displayed)
            {
                HTMLEmailStatusReportlink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnPartnerAccountsLink()
        {
            if (PartnerAccountsLink.Displayed)
            {
                PartnerAccountsLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnMailingListLink()
        {
            if (MailingListLink.Displayed)
            {
                MailingListLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnContactHistoryReportLink()
        {
            if (ContactHistoryReportLink.Displayed)
            {
                ContactHistoryReportLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnBouncedContactsLink()
        {
            if (BouncedContactsLink.Displayed)
            {
                BouncedContactsLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnGoToReportsLink()
        {
            if (GoToReportsLink.Displayed)
            {
                GoToReportsLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnSyncToOutlookLink()
        {
            if (SyncToOutlookLink.Displayed)
            {
                SyncToOutlookLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnImportOrganisationsNContactsLink()
        {
            if (ImportOrganisationsNContactsLink.Displayed)
            {
                ImportOrganisationsNContactsLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnMassDeleteContactsLink()
        {
            if (MassDeleteContactsLink.Displayed)
            {
                MassDeleteContactsLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnMassEmailContactsLink()
        {
            if (MassEmailContactsLink.Displayed)
            {
                MassEmailContactsLink.Click();
            }
            else
            {
                    throw new Exception("Element is not found or not clickable");
            }
        }

        public void FindContactDataFromTable(string contactDetl)
        {
            if (contactDetl != null)
            {
                var x2 = contactDetl;
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
        public void ReturnTableData()
        {
            // xpath of html table
            var elemTable = driver.FindElement(_tableRecentContacts);

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
