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

    public class CategoriesEditPage : BasePage
    {
        #region Constructor
        public CategoriesEditPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Identify fields
        private By _labelHeadStep1 = By.XPath("//*[@id='head_mdStep1_ep']/h3");
        #endregion
        #region Public methods
        public void VerifyPage()
        {
            Assert.AreEqual("Category Edit: New Category ~ Salesforce - Enterprise Edition", driver.Title);
        }
        #endregion
    }
}
