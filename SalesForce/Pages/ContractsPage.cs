using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SalesForce.Pages
{
    public class ContractsPage : BasePage
    {
        #region constructor
        public ContractsPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Public methods
        public void VerifyPage()
        {
            Assert.AreEqual("Contracts: Home ~ Salesforce - Enterprise Edition", driver.Title);
        }
        #endregion
    }
}
