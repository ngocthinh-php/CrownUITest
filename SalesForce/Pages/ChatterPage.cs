using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesForce.Pages
{
    public class ChatterPage: BasePage
    {
        #region constructor
        public ChatterPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Public methods
        public void VerifyPage()
        {
            Assert.AreEqual("Chatter ~ Salesforce - Enterprise Edition", driver.Title);
        }
        #endregion
    }
}
