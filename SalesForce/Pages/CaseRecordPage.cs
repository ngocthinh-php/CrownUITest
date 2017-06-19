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

    public class CaseRecordPage : BasePage
    {
        #region Constructor
        public CaseRecordPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

    }
}
