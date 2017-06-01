using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using System.Threading;

namespace SalesForce.Pages
{
    public class SFHomePage : SFBasePage
    {
        public SFHomePage(IWebDriver Driver) : base(Driver) { }

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

        //private By _lnkAccountEmailDomains = By.CssSelector(a.listRelatedObject.Custom37Block.title);
        private By _lnkAccountEmailDomains = By.LinkText("Account Email Domains");
        private By _lnkArticleManagement = By.LinkText("Article Management");
        private By _lnkCampaigns = By.LinkText("Campaigns");
        private By _lnkCases = By.LinkText("Cases");
        private By _lnkCategories = By.LinkText("Categories");
        private By _lnkCCSAssets = By.LinkText("CCS Assets");
        private By _lnkChatter = By.LinkText("Chatter");
        private By _lnkCloudingo = By.LinkText("Cloudingo");
        private By _lnkContacts = By.LinkText("Contacts");
        private By _lnkContent = By.LinkText("Content");
        private By _lnkContracts = By.LinkText("Contracts");
        private By _lnkDashboards = By.LinkText("Dashboards");
        private By _lnkEmailDomains = By.LinkText("Email Domains");
        private By _lnkForecasts = By.LinkText("Forecasts");
        private By _lnkFrameworks = By.LinkText("Frameworks");
        private By _lnkGroups = By.LinkText("Groups");
        private By _lnkHome = By.LinkText("Home");
        private By _lnkIdeas = By.LinkText("Ideas");
        private By _lnkInstructions = By.LinkText("Instructions");
        private By _lnkKnowledge = By.LinkText("Knowledge");
        private By _lnkLeads = By.LinkText("Leads");
        private By _lnkLegacySystems = By.LinkText("Legacy Systems");
        private By _lnkLibraries = By.LinkText("Libraries");
        private By _lnkManagement = By.LinkText("Management");
        private By _lnkOpportunities = By.LinkText("Opportunites");
        private By _lnkOrders = By.LinkText("Orders");
        private By _lnkOrganisations = By.LinkText("Organisations");
        private By _LnkPeople = By.LinkText("People");
        private By _lnkPriceBooks = By.LinkText("Price Books");
        private By _lnkProcurementStages = By.LinkText("Procurement Stages");
        private By _lnkProducts = By.LinkText("Products");
        private By _LnkProfile = By.LinkText("Profile");
        private By _lnkProfileFeed = By.LinkText("Profile Feed");
        private By _lnkProfileOverView = By.LinkText("Profile Overview");
        private By _lnkReports = By.LinkText("Reports");
        private By _lnkRisksAndIssues = By.LinkText("Risks & Issues");
        private By _lnkSalesforceContracts = By.LinkText("Salesforce Contracts");
        private By _lnkSolutions = By.LinkText("Solutions");
        private By _lnkSubscriptions = By.LinkText("Subscriptions");
        private By _lnkTriageLevels = By.LinkText("Triage Levels");

        
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
        public IWebElement AccountEmailDomainsLink
        {
            get
            {
                return driver.FindElement(_lnkAccountEmailDomains);
            }
        }
        public IWebElement ArticleManagementLink
        {
            get
            {
                return driver.FindElement(_lnkArticleManagement);
            }
        }
        public IWebElement CampaignsLink
        {
            get
            {
                return driver.FindElement(_lnkCampaigns);
            }
        }
        public IWebElement CasesLink
        {
            get
            {
                return driver.FindElement(_lnkCases);
            }
        }
        public IWebElement CategoriesLink
        {
            get
            {
                return driver.FindElement(_lnkCategories);
            }
        }
        public IWebElement ChatterLink
        {
            get
            {
                return driver.FindElement(_lnkChatter);
            }
        }
        public IWebElement ContactsLink
        {
            get
            {
                return driver.FindElement(_lnkContacts);
            }
        }
        public IWebElement ContentsLink
        {
            get
            {
                return driver.FindElement(_lnkContent);
            }
        }
        public IWebElement ContractsLink
        {
            get
            {
                return driver.FindElement(_lnkContracts);
            }
        }
        public IWebElement DashboardsLink
        {
            get
            {
                return driver.FindElement(_lnkDashboards);
            }
        }
        public IWebElement EmailDomainsLink
        {
            get
            {
                return driver.FindElement(_lnkEmailDomains);
            }
        }
        public IWebElement ForecastsLink
        {
            get
            {
                return driver.FindElement(_lnkForecasts);
            }
        }
        public IWebElement FrameworksLink
        {
            get
            {
                return driver.FindElement(_lnkFrameworks);
            }
        }
        public IWebElement GroupsLink
        {
            get
            {
                return driver.FindElement(_lnkGroups);
            }
        }
        public IWebElement HomeLink
        {
            get
            {
                return driver.FindElement(_lnkHome);
            }
        }
        public IWebElement KnowledgeLink
        {
            get
            {
                return driver.FindElement(_lnkKnowledge);
            }
        }
        public IWebElement OrdersLink
        {
            get
            {
                return driver.FindElement(_lnkOrders);            }
        }
        public IWebElement OrganisationsLink
        {
            get
            {
                return driver.FindElement(_lnkOrganisations);
            }
        }
        public IWebElement TriageLevelLink
        {
            get
            {
                return driver.FindElement(_lnkTriageLevels);
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
        public void ClickOnAccountEmailDomainsLink()
        {
            if (EmailDomainsLink.Displayed)
            {
                EmailDomainsLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }

        }
        public void ClickOnArticleManagementLink()
        {
            if (ArticleManagementLink.Displayed)
            {
                ArticleManagementLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }

        }
        public void ClickOnCampaignsLink()
        {
            if (CampaignsLink.Displayed)
            {
                CampaignsLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }

        }
        public void ClickOnCasesLink()
        {
            if (CasesLink.Displayed)
            {
                CasesLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }

        }
        public void ClickOnCategoriesLink()
        {
            if (CategoriesLink.Displayed)
            {
                CategoriesLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }

        }
        public void ClickOnChatterLink()
        {
            if (ChatterLink.Displayed)
            {
                ChatterLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }

        }
        public void ClickOnContactsLink()
        {
            if (ContactsLink.Displayed)
            {
                ContactsLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }

        }
        public void ClickOnDashboardsLink()
        {
            if (DashboardsLink.Displayed)
            {
                DashboardsLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }

        }
        public void ClickOnEmailDomainsLink()
        {
            if (EmailDomainsLink.Displayed)
            {
                EmailDomainsLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }

        }
        public void ClickOnForecastsLink()
        {
            if (ForecastsLink.Displayed)
            {
                ForecastsLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }

        }
        public void ClickOnFrameworksLink()
        {
            if (FrameworksLink.Displayed)
            {
                FrameworksLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }

        }
        public void ClickOnGroupsLink()
        {
            if (GroupsLink.Displayed)
            {
                GroupsLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }

        }
        public void ClickOnHomeLink()
        {
            if (HomeLink.Displayed)
            {
                HomeLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }

        }
        public void ClickOnKnowledgeLink()
        {
            if (KnowledgeLink.Displayed)
            {
                KnowledgeLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }

        }
        public void ClickOnOrdersLink()
        {
            if (OrdersLink.Displayed)
            {
                OrdersLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }

        }
        public void ClickOnOrganisationsLink()
        {
            if (OrganisationsLink.Displayed)
            {
                OrganisationsLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }

        }
        public void ClickOnTriageLevelLink()
        {
            if (TriageLevelLink.Displayed)
            {
                TriageLevelLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        #endregion
    }
}
