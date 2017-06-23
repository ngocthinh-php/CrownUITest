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
        private By inputParameter;
        #region constructor
        public HandleTableData(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion
        #region Public methods
        public void ReturnTableData()
        {
            // xpath of html table
            var elemTable = driver.FindElement(inputParameter);

            // Fetch all Row of the table
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            String strRowData = "";

            // Traverse each row
            foreach (var elemTr in lstTrElem)
            {
                // Fetch the columns from a particuler row
                List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                if (lstTdElem.Count > 0)
                {
                    // Traverse each column
                    foreach (var elemTd in lstTdElem)
                    {
                        // "\t\t" is used for Tab Space between two Text
                        strRowData = strRowData + elemTd.Text + "\t\t";
                    }
                }
                else
                {
                    // To print the data into the console
                    Console.WriteLine("Data Retrieved");
                }
                strRowData = String.Empty;
            }
        }
#endregion
    }
}
