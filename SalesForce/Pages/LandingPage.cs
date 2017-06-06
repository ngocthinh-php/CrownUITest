using System;
using OpenQA.Selenium;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalesForce.Pages
{
    public class LandingPage : BasePage
    {
        public LandingPage(IWebDriver Driver) : base(Driver) { }

        #region Properties and fields
        private By _typeSearchBox = By.XPath("//*[@id='phSearchInput']");
        private By _btnSearch = By.XPath("//*[@id='phSearchButton']");
        private By _icoCCS = By.XPath("//*[@id='home_Tab']/a");
        private By _tabHome = By.XPath("//*[@id='home_Tab']/a");
        private By _tabChatter = By.XPath("//*[@id='Chatter_Tab']/a");
        private By _tabOrganisation = By.XPath("//*[@id='Account_Tab']/a");
        private By _tabContacts = By.XPath("//*[@id='Contact_Tab']/a");
        private By _tabCases = By.XPath("//*[@id='Case_Tab']/a");
        private By _tabContracts = By.XPath("//*[@id='01rb00000009tLh_Tab']/a");
        private By _tabFrameworks = By.XPath("//*[@id='01rb0000000E9fq_Tab']/a");
        private By _tabReports = By.XPath("//*[@id='report_Tab']/a");
        private By _tabKnowledge = By.XPath("//*[@id='Knowledge_Tab']/a");
        private By _tabTriageLevels = By.XPath("//*[@id='01r4E000000DAJP_Tab']/a");
        private By _tabMoreTabs = By.Id("MoreTabs_Tab");
        private By _lnkHideFeed = By.XPath("//*[@id='hideFeedLink']/a/span");
        private By _lnkShowFeed = By.XPath("//*[@id='showFeedLink']/a/span");
        private By _sectionDashboard = By.CssSelector("pbTitle>h2");
        private By _btnRefreshDashBoard = By.XPath("//*[@id='db_ref_btn']");
        private By _sectionMyTasks = By.XPath("//*[@id='actionForm']/div[1]/table/tbody/tr/td[1]/h3");
        private By _btnNewTask = By.XPath("//*[@id='actionForm']/div[1]/table/tbody/tr/td[2]/input");
        private By _sectionItemsToApprove = By.XPath("//*[@id='PendingProcessWorkitemsList_title']");
        private By _btnManageAllItemsToApprove = By.XPath("//*[@id='PendingProcessWorkitemsList']/div[1]/div/div[1]/table/tbody/tr/td[2]/input");
        private By _sectionCalendar = By.XPath("//*[@id='homeCalendarSection']/div/div[1]/table/tbody/tr/td[1]/h3");
        private By _btnNewEventCalendar = By.XPath("//*[@id='homeCalendarSection']/div/div[1]/table/tbody/tr/td[2]/input[1]");
        private By _btnNewMeetingRequestCalendar = By.XPath("//*[@id='homeCalendarSection']/div/div[1]/table/tbody/tr/td[2]/input[2]");
        private By _tabAllTabs = By.XPath("//*[@id='AllTab_Tab']/a");
        private By _lnkProfileHeader = By.XPath("//*[@id='globalHeaderNameMink']");
        private By _lnkMySettings = By.XPath("//*[@id='globalHeaderBar']/div[2]/div/div/div/ul/li[1]/a");
        private By _lnkSetUp = By.XPath("//*[@id='globalHeaderBar']/div[2]/div/div/div/ul/li[2]/a");
        private By _lnkEditContactInfo = By.XPath("//*[@id='globalHeaderBar']/div[2]/div/div/div/ul/li[3]/a");
        private By _lnkDeveloperConsole = By.XPath("//*[@id='globalHeaderBar']/div[2]/div/div/div/ul/li[4]/a");
        private By _lnkHelpAndTraining = By.XPath("//*[@id='globalHeaderBar']/div[2]/div/div/div/ul/li[5]/a");
        //private By _lnkLogOut = By.XPath("//*[@id='globalHeaderBar']/div[2]/div/div/div/ul/li[6]/a");
        private By _lnkLogOut = By.LinkText("Logout");

        public IWebElement SearchBox
        {
            get
            {
                return driver.FindElement(_typeSearchBox);
            }

        }
        public IWebElement SearchBtn
        {
            get
            {
                return driver.FindElement(_btnSearch);
            }
        }
        public IWebElement HomeTab
        {
            get
            {
                return driver.FindElement(_tabHome);
            }
        }
        public IWebElement ChatterTab
        {
            get
            {
                return driver.FindElement(_tabChatter);
            }
        }
        public IWebElement OrganisationTab
        {
            get
            {
                return driver.FindElement(_tabOrganisation);
            }
        }
        public IWebElement ContactsTab
        {
            get
            {
                return driver.FindElement(_tabContacts);
            }
        }
        public IWebElement CasesTab
        {
            get
            {
                return driver.FindElement(_tabCases);
            }
        }
        public IWebElement ContractsTab
        {
            get
            {
                return driver.FindElement(_tabContracts);
            }
        }
        public IWebElement FrameworksTab
        {
            get
            {
                return driver.FindElement(_tabFrameworks);
            }
        }
        public IWebElement ReportsTab
        {
            get
            {
                return driver.FindElement(_tabReports);
            }
        }
        public IWebElement KnowledgeTab
        {
            get
            {
                return driver.FindElement(_tabKnowledge);
            }
        }
        public IWebElement TriageLevelsTab
        {
            get
            {
                return driver.FindElement(_tabTriageLevels);
            }
        }
        public IWebElement AllTabsIcon
        {
            get
            {
                return driver.FindElement(_tabAllTabs);
            }

        }
        public IWebElement MoreTabs
        {
            get
            {
                return driver.FindElement(_tabMoreTabs);
            }
        }
        public IWebElement HideFeed
        {
            get
            {
                return driver.FindElement(_lnkHideFeed);
            }
        }
        public IWebElement ShowFeed
        {
            get
            {
                return driver.FindElement(_lnkShowFeed);
            }
        }
        public IWebElement RefreshDashboard
        {
            get
            {
                return driver.FindElement(_btnRefreshDashBoard);
            }
        }
        public IWebElement NewTask
        {
            get
            {
                return driver.FindElement(_btnNewTask);
            }
        }
        public IWebElement ManageAllItemsToApprove
        {
            get
            {
                return driver.FindElement(_btnManageAllItemsToApprove);
            }
        }
        public IWebElement NewEvent
        {
            get
            {
                return driver.FindElement(_btnNewEventCalendar);
            }
        }
        public IWebElement NewMeetingRequest
        {
            get
            {
                return driver.FindElement(_btnNewMeetingRequestCalendar);
            }
        }
        public IWebElement ProfileHeader
        {
            get
            {
                return driver.FindElement(_lnkProfileHeader);
            }
        }
        public IWebElement MySettings
        {
            get
            {
                return driver.FindElement(_lnkMySettings);
            }
        }
        public IWebElement SetUp
        {
            get
            {
                return driver.FindElement(_lnkSetUp);
            }
        }
        public IWebElement EditContactInfo
        {
            get
            {
                return driver.FindElement(_lnkEditContactInfo);
            }
        }
        public IWebElement DeveloperConsole
        {
            get
            {
                return driver.FindElement(_lnkDeveloperConsole);
            }
        }
        public IWebElement HelpAndTraining
        {
            get
            {
                return driver.FindElement(_lnkHelpAndTraining);
            }
        }
        public IWebElement LogOut
        {
            get
            {
                return driver.FindElement(_lnkLogOut);
            }
        }

        #endregion

        #region Public methods
        public void VerifyPage()
        {
            Assert.AreEqual("Salesforce - Enterprise Edition", driver.Title);
            Assert.IsTrue(SearchBox.Displayed);
            Assert.IsTrue(SearchBtn.Displayed);
            Assert.IsTrue(AllTabsIcon.Displayed);
            //Assert.IsTrue(AccountEmailDomainsLnk.Displayed);

        }

        public void SearchText(string inputsearchtext)
        {
            GetDisplayedElement(_typeSearchBox, 500, 15000).SendKeys(inputsearchtext);
        }
        //public void UserLogin(string email, string password)
        //{
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        //    wait.Until(ExpectedConditions.ElementToBeClickable(_typeUserName));
        //    UserEmail.Clear();
        //    UserEmail.SendKeys(email);
        //    Thread.Sleep(2000);
        //    wait.Until(ExpectedConditions.ElementToBeClickable(_typePassword));
        //    SearchBtn.Clear();
        //    SearchBtn.SendKeys(password);
        //}

        public void ClickOnHomeTab()
        {
            if (HomeTab.Displayed)
            {
                HomeTab.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnChatterTab()
        {
            if(ChatterTab.Displayed)
            {
                ChatterTab.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnOrganisationTab()
        {
            if (OrganisationTab.Displayed)
            {
                OrganisationTab.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnContactsTab()
        {
            if (ContactsTab.Displayed)
            {
                ContactsTab.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnCasesTab()
        {
            if (CasesTab.Displayed)
            {
                CasesTab.Click();
            }
        }
        public void ClickOnContractsTab()
        {
            if (ContractsTab.Displayed)
            {
                ContractsTab.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnFrameworksTab()
        {
            if (FrameworksTab.Displayed)
            {
                FrameworksTab.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnReportsTab()
        {
            if (ReportsTab.Displayed)
            {
                ReportsTab.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnKnowledgeTab()
        {
            if (KnowledgeTab.Displayed)
            {
                KnowledgeTab.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnTriageLevelsTab()
        {
            if (TriageLevelsTab.Displayed)
            {
                TriageLevelsTab.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnAllTabsIcon()
        {
            if (AllTabsIcon.Displayed)
            {
                AllTabsIcon.Click();
                Thread.Sleep(5000);
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnProfileHeader()
        {
            if (ProfileHeader.Displayed)
            {
                ProfileHeader.Click();
                Thread.Sleep(3000);
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnLogout()
        {
            if (LogOut.Displayed)
            {
                LogOut.Click();
                Thread.Sleep(3000);
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        #endregion
    }
}
