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

    public class CategoriesRecordPage : BasePage
    {
        #region Constructor
        public CategoriesRecordPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Properties and fields
        private By _labelCatRecHeader = By.XPath("//*[@id='bodyCell']/div[1]/div[1]/div[1]/h2");

        private By _btnEditTop = By.XPath("//*[@id='topButtonRow']/input[3]");
        private By _btnDeleteTop = By.XPath("//*[@id='topButtonRow']/input[4]");
        private By _btnCloneTop = By.XPath("//*[@id='topButtonRow']/input[5]");
        private By _btnSharingTop = By.XPath("//*[@id='topButtonRow']/input[6]");
        private By _btnEditBottom = By.XPath("//*[@id='bottomButtonRow']/input[3]");
        private By _btnDeleteBottom = By.XPath("//*[@id='bottomButtonRow']/input[4]");
        private By _btnCloneBottom = By.XPath("//*[@id='bottomButtonRow']/input[5]");
        private By _btnSharingBottom = By.XPath("//*[@id='bottomButtonRow']/input[6]");

        public IWebElement CatRecHeaderText
        {
            get
            {
                return driver.FindElement(_labelCatRecHeader);
            }
        }
        public IWebElement TopEditButton
        {
            get
            {
                return driver.FindElement(_btnEditTop);
            }
        }
        public IWebElement TopDeleteButton
        {
            get
            {
                return driver.FindElement(_btnDeleteTop);
            }
        }
        public IWebElement TopCloneButton
        {
            get
            {
                return driver.FindElement(_btnCloneTop);
            }
        }
        public IWebElement TopSharingButton
        {
            get
            {
                return driver.FindElement(_btnSharingTop);
            }
        }

        public IWebElement BottomEditButton
        {
            get
            {
                return driver.FindElement(_btnEditBottom);
            }
        }
        public IWebElement BottomDeleteButton
        {
            get
            {
                return driver.FindElement(_btnDeleteBottom);
            }
        }
        public IWebElement BottomCloneButton
        {
            get
            {
                return driver.FindElement(_btnCloneBottom);
            }
        }
        public IWebElement BottomSharingButton
        {
            get
            {
                return driver.FindElement(_btnSharingBottom);
            }
        }
        #endregion

        #region Public methods
        public void VerifyPage()
        {
            Assert.AreEqual("Category: "+CatRecHeaderText.Text+" ~ Salesforce - Enterprise Edition", driver.Title);
        }
        public void ClickOnTopEditButton()
        {
            if (TopEditButton.Displayed)
            {
                TopEditButton.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnTopDeleteButton()
        {
            if (TopDeleteButton.Displayed)
            {
                TopDeleteButton.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnTopCloneButton()
        {
            if (TopCloneButton.Displayed)
            {
                TopCloneButton.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnTopSharingButton()
        {
            if (TopSharingButton.Displayed)
            {
                TopSharingButton.Click();
            }
            else
            {
                Exception e;
            }
        }

        public void ClickOnBottomEditButton()
        {
            if (BottomEditButton.Displayed)
            {
                BottomEditButton.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnBottomDeleteButton()
        {
            if (BottomDeleteButton.Displayed)
            {
                BottomDeleteButton.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnBottomCloneButton()
        {
            if (BottomCloneButton.Displayed)
            {
                BottomCloneButton.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnBottomSharingButton()
        {
            if (BottomSharingButton.Displayed)
            {
                BottomSharingButton.Click();
            }
            else
            {
                Exception e;
            }
        }

        #endregion

    }
}
