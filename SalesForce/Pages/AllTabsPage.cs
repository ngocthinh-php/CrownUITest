using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SalesForce.Pages
{
    public class AllTabsPage : BasePage
    {
        #region constructor
        public AllTabsPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Properties and fields
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

        public IWebElement ReportsLink
        {
            get
            {
                return driver.FindElement(_lnkReports);
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
                return driver.FindElement(_lnkOrders);
            }
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
            Assert.AreEqual("All Tabs ~ Salesforce - Enterprise Edition", driver.Title);
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
        public void ClickOnContractsLink()
        {
            if (ContractsLink.Displayed)
            {
                ContractsLink.Click();
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
        public void ClickOnReportsLink()
        {
            if (ReportsLink.Displayed)
            {
                ReportsLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }

        }
        #endregion

    }
}
