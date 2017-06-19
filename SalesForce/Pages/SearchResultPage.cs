using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SalesForce.Pages
{
    public class SearchResultPage : BasePage
    {
        public SearchResultPage(IWebDriver Driver) : base(Driver)
        {
        }
        private By _frameAccountSearchResult = By.XPath("//*[@id='Account']/div[2]/div");
        private By _frameContactSearchResult = By.XPath("//*[@id='Contact']/div[2]/div");
        private By _frameCaseSearchResult = By.XPath("//*[@id='Case']/div[2]/div");
        private By _recordAccount = By.XPath("//*[@id='Account_body']/table/tbody/tr[2]/th/a");
        private By _recordContact = By.XPath("//*[@id='Contact_body']/table/tbody/tr[2]/th/a");
        private By _recordCase = By.XPath("//*[@id='Case_body']/table/tbody/tr[2]/th/a");

        public IWebElement AccountSearchResult
        {
            get
            {
                return driver.FindElement(_frameAccountSearchResult);
            }
        }
        public IWebElement ContactSearchResult
        {
            get
            {
                return driver.FindElement(_frameContactSearchResult);
            }
        }
        public IWebElement CaseSearchResult
        {
            get
            {
                return driver.FindElement(_frameCaseSearchResult);
            }
        }
        public IWebElement AccountRecord
        {
            get
            {
                return driver.FindElement(_recordAccount);
            }
        }
        public IWebElement ContactRecord
        {
            get
            {
                return driver.FindElement(_recordContact);
            }
        }
        public IWebElement CaseRecord
        {
            get
            {
                return driver.FindElement(_recordCase);
            }
        }
        public void LoadAccountRecord()
        {
            if (AccountRecord.Displayed)
            {
                AccountRecord.Click();
            }
            else
            {
                throw new Exception("Record is not found or not clickable");
            }
        }
        public void LoadContactRecord()
        {
            if (ContactRecord.Displayed)
            {
                ContactRecord.Click();
                driver.FindElement(By.CssSelector("#efpViews_0037E00000Sk04D_option1 > span.optionLabel")).Click();
            }
            else
            {
                throw new Exception("Record is not found or not clickable");
            }
        }
        public void LoadCaseRecord()
        {
            if (CaseRecord.Displayed)
            {
                CaseRecord.Click();
            }
            else
            {
                throw new Exception("Record is not found or not clickable");
            }
        }
        public void VerifyAccountOutput()
        {
            Assert.IsTrue(AccountSearchResult.Displayed);
            Assert.IsTrue(AccountRecord.Displayed);
        }
        public void VerifyContactOutput()
        {
            Assert.IsTrue(ContactSearchResult.Displayed);
            Assert.IsTrue(ContactRecord.Displayed);
        }
        public void VerifyCaseOutput()
        {
            Assert.IsTrue(CaseSearchResult.Displayed);
            Assert.IsTrue(CaseRecord.Displayed);
        }

     }
}
