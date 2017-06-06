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
    public class OrganisationsPage : BasePage
    {
        #region constructor
        public OrganisationsPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Properties and fields
        private By _lstViewOrganisations = By.XPath("//*[@id='fcf']");
        private By _btnGo = By.XPath("//*[@id='filter_element']/div/span/span[1]/input");
        private By _lnkEdit = By.LinkText("Edit");
        private By _lnkCreateNewView = By.LinkText("Create New View");
        private By _frameRecentOrganisations = By.XPath("//*[@id='bodyCell']/div[3]/div[1]/div");
        private By _lblRecentOrganisations = By.XPath("//*[@id='hotlist']/table/tbody/tr/td[1]/h3");
        private By _btnNew = By.XPath("//*[@id='hotlist']/table/tbody/tr/td[2]/input");
        private By _lstRecentItem = By.XPath("//*[@id='hotlist_mode']");
        private By _frameReports = By.XPath("//*[@id='toolsContent']/tbody/tr/td[1]/div/div");
        private By _frameTools = By.XPath("//*[@id='toolsContent']/tbody/tr/td[2]/div/div");

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
                return driver.FindElement(_lstRecentItem);
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
        #endregion
    }
}
