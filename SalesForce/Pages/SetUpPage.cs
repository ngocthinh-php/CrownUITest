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
    #endregion

    public class SetUpPage : BasePage
    {
        #region constructor
        public SetUpPage(IWebDriver Driver) : base(Driver) { }
        #endregion

        #region Properties and fields
        private By _labelRecentItemHeader = By.XPath("//*[@id='content_wrap:mruTable']/thead/tr[1]/th/div/div/h2");
        private By _labelQuickLinksHeader = By.XPath("//*[@id='quicklinks']/div[1]/div/h2");
        private By _labelCommunityHeader = By.XPath("//*[@id='newFeatures']/div[1]/div/h2");
        private By _txtSetUpQuickFindSearch = By.XPath("//*[@id='setupSearch']");
        private By _btnSetUpSearch = By.XPath("//*[@id='setupSearchButton']");

        #endregion
        #region define element attributes
        public IWebElement RecentItemFrameHeader
        {
            get
            {
                return driver.FindElement(_labelRecentItemHeader);
            }
        }
        public IWebElement QuickLinksHeader
        {
            get
            {
                return driver.FindElement(_labelQuickLinksHeader);
            }
        }
        public IWebElement CommunityHeader
        {
            get
            {
                return driver.FindElement(_labelCommunityHeader);
            }
        }
        public IWebElement QuickFindSearchTextBox
        {
            get
            {
                return driver.FindElement(_txtSetUpQuickFindSearch);
            }
        }
        public IWebElement SetUpSearchButton
        {
            get
            {
                return driver.FindElement(_btnSetUpSearch);
            }
        }
        #endregion
        #region public method
        public void VerifyPage()
        {
            Assert.IsTrue(RecentItemFrameHeader.Displayed);
            Assert.IsTrue(QuickLinksHeader.Displayed);
            Assert.IsTrue(CommunityHeader.Displayed);
            Assert.IsTrue(QuickFindSearchTextBox.Displayed);
            Assert.IsTrue(SetUpSearchButton.Displayed);
        }
        //public void ClickOnFeedTab()
        //{
        //    if (DetailsTab.Enabled)
        //    {
        //        FeedTab.Click();
        //    }
        //    else
        //    {
        //        throw new Exception("Feed tab is not found or not clickable");
        //    }
        //}
        #endregion
    }
}
