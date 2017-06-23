/// <summary>
/// This page has not been implemented completely. Not all the elements are defined
/// </summary>
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
    using OpenQA.Selenium.Interactions;
    #endregion

    public class ContactsRecordPage : BasePage
    {
        #region constructor
        public ContactsRecordPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Identify fields 
        private By _labelContactHeader = By.XPath("//*[@id='contactHeaderRow']/div[2]/h2");
        private By _tabFeed = By.XPath("//*[@id='efpViews_0037E00000TAXH7_option0']");
        private By _tabDetails = By.XPath("//*[@id='efpViews_0037E00000TAXH7_option1']");
        #endregion

        #region Properties
        public IWebElement ContactHeader
        {
            get
            {
                return driver.FindElement(_labelContactHeader);
            }
        }
        public IWebElement FeedTab
        {
            get
            {
                return driver.FindElement(_tabFeed);

            }
        }
        public IWebElement DetailsTab
        {
            get
            {
                return driver.FindElement(_tabDetails);
            }
        }


        #endregion

        #region Public methods
        public void VerifyPage()
        {
            Assert.AreEqual(ContactHeader.Text+" ~ Salesforce - Enterprise Edition", driver.Title);
        }
        public void GoToFeedTab()
        {
            if (FeedTab.Displayed)
            {
                FeedTab.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void GoToDetailsTab()
        {
            if (DetailsTab.Displayed)
            {
                DetailsTab.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        #endregion
    }
}
