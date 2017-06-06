using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SalesForce.Pages
{
    public class KnowledgePage : BasePage
    {
        #region constructor
        public KnowledgePage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Public methods
        public void VerifyPage()
        {
            Assert.AreEqual("Knowledge Search ~ Salesforce - Enterprise Edition", driver.Title);
        }
        #endregion
    }
}
