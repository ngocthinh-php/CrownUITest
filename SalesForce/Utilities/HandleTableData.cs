namespace SalesForce.Utilities
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
    using Pages;
    #endregion

    public class HandleTableData : BasePage
    {
        #region constructor
        public HandleTableData(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

    }
}
