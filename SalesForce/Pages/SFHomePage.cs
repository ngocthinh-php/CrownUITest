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
        private By _icoAllTabs = By.XPath("//*[@id='AllTab_Tab']/a");
        //private By _lnkAccountEmailDomains = By.CssSelector(a.listRelatedObject.Custom37Block.title);
        private By _lnkAccountEmailDomains = By.LinkText("Account Email Domains");

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
        public IWebElement AllTabsIcon
        {
            get
            {
                return driver.FindElement(_icoAllTabs);
            }

        }
        public IWebElement AccountEmailDomainsLnk
        {
            get
            {
                return driver.FindElement(_lnkAccountEmailDomains);
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

        #endregion
    }
}
