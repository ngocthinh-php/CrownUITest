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

    public class CaseNewPage : BasePage
    {
        #region Constructor
        public CaseNewPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        private By _lstRecordType = By.XPath("//*[@id='p3']");
        private By _btnContinue = By.XPath("//*[@id='bottomButtonRow']/input[1]");
        private By _btnCancel = By.XPath("//*[@id='bottomButtonRow']/input[2]");

        public IWebElement ContinueButton
        {
            get
            {
                return driver.FindElement(_btnContinue);
            }
        }
        public IWebElement CancelButton
        {
            get
            {
                return driver.FindElement(_btnCancel);
            }
        }
        public IWebElement RecordTypeList
        {
            get
            {
                return driver.FindElement(_lstRecordType);
            }
        }

        public void SelectCaseType(string caseType)
        {
            IWebElement dropDownListBox = driver.FindElement(_lstRecordType);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            Thread.Sleep(2000);
            clickThis.SelectByText(caseType);
            Thread.Sleep(2000);

        }
        public void VerifyPage()
        {
            Assert.AreEqual("New Case: Select Case Record Type ~ Salesforce - Enterprise Edition", driver.Title);
            Assert.IsTrue(RecordTypeList.Displayed);
        }
        public void ClickOnContinueButton()
        {
            if (ContinueButton.Displayed)
            {
                ContinueButton.Click();
                Thread.Sleep(3000);
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnCancelButton()
        {
            if (CancelButton.Displayed)
            {
                CancelButton.Click();
                Thread.Sleep(3000);
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
    }
}
