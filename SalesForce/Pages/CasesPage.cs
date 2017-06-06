using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SalesForce.Pages
{
    public class CasesPage : BasePage
    {
        #region constructor
        public CasesPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Public methods
        public void VerifyPage()
        {
            Assert.AreEqual("Cases: Home ~ Salesforce - Enterprise Edition", driver.Title);
        }
        #endregion
    }
}
