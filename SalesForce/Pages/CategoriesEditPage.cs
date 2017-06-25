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

    public class CategoriesEditPage : BasePage
    {
        #region Constructor
        public CategoriesEditPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Identify fields
        private By _txtCategoryName = By.XPath("//*[@id='Name']");
        private By _txtCategoryCode = By.XPath("//*[@id='00Nb000000ASEWZ']");
        private By _listCategoryType = By.XPath("//*[@id='00Nb0000009cWTt']");
        private By _txtParent = By.XPath("//*[@id='CF00Nb0000009cWTv']");
        private By _listCodeType = By.XPath("//*[@id='00Nb000000ASEWa']");
        private By _txtCatExternalId = By.XPath("//*[@id='00Nb000000ASEWY']");
        private By _txtParentName = By.XPath("//*[@id='00Nb000000ASEWd']");
        private By _txtPGDescription = By.XPath("//*[@id='00Nb000000ASEWe']");
        private By _btnSaveTop = By.XPath("//*[@id='topButtonRow']/input[1]");
        private By _btnSaveAndNewTop = By.XPath("//*[@id='topButtonRow']/input[2]");
        private By _btnCancelTop = By.XPath("//*[@id='topButtonRow']/input[3]");
        private By _btnSaveButtom = By.XPath("//*[@id='bottomButtonRow']/input[1]");
        private By _btnSaveAndNewBottom = By.XPath("//*[@id='bottomButtonRow']/input[2]");
        private By _btnCancelBottom = By.XPath("//*[@id='bottomButtonRow']/input[3]");

        public IWebElement CategoryName
        {
            get
            {
                return driver.FindElement(_txtCategoryName);
            }
        }
        public IWebElement CategoryCode
        {
            get
            {
                return driver.FindElement(_txtCategoryCode);
            }
        }
        public IWebElement CategoryTypeList
        {
            get
            {
                return driver.FindElement(_listCategoryType);
            }
        }
        public IWebElement Parent
        {
            get
            {
                return driver.FindElement(_txtParent);
            }
        }
        public IWebElement CodeTypeList
        {
            get
            {
                return driver.FindElement(_listCodeType);
            }
        }
        public IWebElement CatExternalId
        {
            get
            {
                return driver.FindElement(_txtCatExternalId);
            }
        }
        public IWebElement ParentName
        {
            get
            {
                return driver.FindElement(_txtParentName);
            }
        }
        public IWebElement PGDescription
        {
            get
            {
                return driver.FindElement(_txtPGDescription);
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
            Assert.AreEqual("Category Edit: New Category ~ Salesforce - Enterprise Edition", driver.Title);
        }
        public void EnterCategoryName(string catName)
        {
            GetDisplayedElement(_txtCategoryName, 500, 15000).SendKeys(catName);           
        }
        public void EnterCategoryCode(string catCode)
        {
            GetDisplayedElement(_txtCategoryCode, 500, 15000).SendKeys(catCode);
        }
        public void SelectCategoryType(string catType)
        {
            if (CategoryTypeList.Displayed)
            { 
                IWebElement dropDownListBox = CategoryTypeList;
                SelectElement clickThis = new SelectElement(dropDownListBox);
                clickThis.SelectByText(catType);
            }
            else
            {
                Exception e;
            }

        }
        public void EnterParent(string parent)
        {
            GetDisplayedElement(_txtParent, 500, 15000).SendKeys(parent);
        }
        public void SelectCodeType(string codeType)
        {
            //if (CodeTypeList.Displayed)
            //{
                IWebElement dropDownListBox = CodeTypeList;
                SelectElement clickThis = new SelectElement(dropDownListBox);
                clickThis.SelectByText(codeType);
            //}
            //else
            //{
            //    Exception e;
            //}
        }
        public void EnterCatExternalId(string catExtId)
        {
            GetDisplayedElement(_txtCatExternalId, 500, 15000).SendKeys(catExtId);
        }
        public void EnterParentName(string pName)
        {
            GetDisplayedElement(_txtParentName, 500, 15000).SendKeys(pName);
        }
        public void EnterPGDescription(string pgDescription)
        {
            GetDisplayedElement(_txtPGDescription, 500, 15000).SendKeys(pgDescription);
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
        public void ClickOnTopSaneAndNewButton()
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
