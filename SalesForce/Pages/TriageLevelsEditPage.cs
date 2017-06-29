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

    public class TriageLevelsEditPage : BasePage
    {
        #region Constructor
        public TriageLevelsEditPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Properties and fields
        private By _txtTriageLevel = By.XPath("//*[@id='Name']");
        private By _listSLADays = By.XPath("//*[@id='00Nb0000009IPdD']");
        private By _chkBoxIsDefault = By.XPath("//*[@id='00Nb0000009IPdC']");
        private By _btnSaveTop = By.XPath("//*[@id='topButtonRow']/input[1]");
        private By _btnSaveAndNewTop = By.XPath("//*[@id='topButtonRow']/input[2]");
        private By _btnCancelTop = By.XPath("//*[@id='topButtonRow']/input[3]");
        private By _btnSaveButtom = By.XPath("//*[@id='bottomButtonRow']/input[1]");
        private By _btnSaveAndNewBottom = By.XPath("//*[@id='bottomButtonRow']/input[2]");
        private By _btnCancelBottom = By.XPath("//*[@id='bottomButtonRow']/input[3]");


        public IWebElement TriageLevel
        {
            get
            {
                return driver.FindElement(_txtTriageLevel);
            }
        }
        public IWebElement SLADays
        {
            get
            {
                return driver.FindElement(_listSLADays);
            }
        }
        public IWebElement IsDefaultCheckBox
        {
            get
            {
                return driver.FindElement(_chkBoxIsDefault);
            }
        }
        public IWebElement TopSaveButton
        {
            get
            {
                return driver.FindElement(_btnSaveTop);
            }
        }
        public IWebElement TopSaveAndNewButton
        {
            get
            {
                return driver.FindElement(_btnSaveAndNewTop);
            }
        }
        public IWebElement TopCancelButton
        {
            get
            {
                return driver.FindElement(_btnCancelTop);
            }
        }
        public IWebElement BottomSaveButton
        {
            get
            {
                return driver.FindElement(_btnSaveButtom);
            }
        }
        public IWebElement BottomSaveAndNewButton
        {
            get
            {
                return driver.FindElement(_btnSaveAndNewBottom);
            }
        }
        public IWebElement BottomCancelButton
        {
            get
            {
                return driver.FindElement(_btnCancelBottom);
            }
        }


        #endregion

        #region Public methods
        public void VerifyPage()
        {
            Assert.AreEqual("Triage Level Edit: New Triage Level ~ Salesforce - Enterprise Edition", driver.Title);
        }
        public void EnterTriageLevel(string triageLevel)
        {
            GetDisplayedElement(_txtTriageLevel, 500, 10000).Clear();
            GetDisplayedElement(_txtTriageLevel, 500, 10000).SendKeys(triageLevel);
        }

        public void SelectSLADays(string slaDays)
        {
            IWebElement dropDownListBox = SLADays;
            SelectElement clickThis = new SelectElement(dropDownListBox);
            clickThis.SelectByText(slaDays);
        }
        public void ClickOnIsDefaultCheckBox()
        {
            if (IsDefaultCheckBox.Displayed)
            {
                IsDefaultCheckBox.Click();
            }
            else
            {
                Exception e;
            } 
        }
        public void ClickOnTopSaveButton()
        {
            if (TopSaveButton.Displayed)
            {
                TopSaveButton.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnTopSaveAndNewButton()
        {
            if (TopSaveAndNewButton.Displayed)
            {
                TopSaveAndNewButton.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnTopCancelButton()
        {
            if (TopCancelButton.Displayed)
            {
                TopCancelButton.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnBottomSaveButton()
        {
            if (BottomSaveButton.Displayed)
            {
                BottomSaveButton.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnBottomSaveAndNewButton()
        {
            if (BottomSaveAndNewButton.Displayed)
            {
                BottomSaveAndNewButton.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnBottomCancelButton()
        {
            if (BottomCancelButton.Displayed)
            {
                BottomCancelButton.Click();
            }
            else
            {
                Exception e;
            }
        }
        #endregion
    }
}
