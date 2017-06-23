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

    public class ContactsMassDeletePage : BasePage
    {
        #region Constructor
        public ContactsMassDeletePage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Identify fields
        private By _labelHeadStep1 = By.XPath("//*[@id='head_mdStep1_ep']/h3");
        private By _labelHeadStep2 = By.XPath("//*[@id='head_mdStep2_ep']/h3");
        private By _labelHeadStep3 = By.XPath("//*[@id='head_mdStep3_ep']/h3");
        private By _labelHeadStep4 = By.XPath("//*[@id='head_mdStep6_ep']/h3");
        private By _chkBoxHardDelete = By.XPath("//*[@id='hardDelete']");
        private By _btnSearch = By.XPath("//*[@id='ep']/div[2]/div[7]/table/tbody/tr[2]/td/div/input");

        private By _paramCol1Row1 = By.XPath("//*[@id='col0']");
        private By _paramCol1Row2 = By.XPath("//*[@id='col1']");
        private By _paramCol1Row3 = By.XPath("//*[@id='col2']");
        private By _paramCol1Row4 = By.XPath("//*[@id='col3']");
        private By _paramCol1Row5 = By.XPath("//*[@id='col4']");

        private By _paramCol2Row1 = By.XPath("//*[@id='oper0']");
        private By _paramCol2Row2 = By.XPath("//*[@id='oper1']");
        private By _paramCol2Row3 = By.XPath("//*[@id='oper2']");
        private By _paramCol2Row4 = By.XPath("//*[@id='oper3']");
        private By _paramCol2Row5 = By.XPath("//*[@id='oper4']");

        private By _paramCol3Row1 = By.XPath("//*[@id='fval0']");
        private By _paramCol3Row2 = By.XPath("//*[@id='fval1']");
        private By _paramCol3Row3 = By.XPath("//*[@id='fval2']");
        private By _paramCol3Row4 = By.XPath("//*[@id='fval3']");
        private By _paramCol3Row5 = By.XPath("//*[@id='fval4']");
        private By _msgPostDelete = By.XPath("//*[@id='ep']/div[2]/div[9]/table/tbody/tr[2]/td/div[1]/div/div[2]/table/tbody/tr[2]/td");


        private By _chkBoxSearchOutputHeader = By.XPath("//*[@id='allBox']");

        private By _btnTopDelete = By.XPath("//*[@id='ep']/div[2]/div[9]/table/tbody/tr[2]/td/div/input");

        private By _btnBottomDelete = By.XPath("//*[@id='ep']/div[2]/div[9]/table/tbody/tr[4]/td/div/input");

        private By _tableSearchOutputData = By.XPath("//*[@id='ep']/div[2]/div[9]/table/tbody/tr[3]/td/div[1]/div/div[2]");
        #endregion

        #region Properties
        public IWebElement HeadStep1Text
        {
            get
            {
                return driver.FindElement(_labelHeadStep1);
            }
        }
        public IWebElement HeadStep2Text
        {
            get
            {
                return driver.FindElement(_labelHeadStep2);
            }
        }
        public IWebElement HeadStep3Text
        {
            get
            {
                return driver.FindElement(_labelHeadStep3);
            }
        }
        public IWebElement HeadStep4Text
        {
            get
            {
                return driver.FindElement(_labelHeadStep4);
            }
        }
        public IWebElement HardDeleteCheckBox
        {
            get
            {
                return driver.FindElement(_chkBoxHardDelete);
            }
        }
        public IWebElement SearchButton
        {
            get
            {
                return driver.FindElement(_btnSearch);
            }
        }

        public IWebElement Col1Row1
        {
            get
            {
                return driver.FindElement(_paramCol1Row1);
            }
        }
        public IWebElement Col1Row2
        {
            get
            {
                return driver.FindElement(_paramCol1Row2);
            }
        }
        public IWebElement Col1Row3
        {
            get
            {
                return driver.FindElement(_paramCol1Row3);
            }
        }
        public IWebElement Col1Row4
        {
            get
            {
                return driver.FindElement(_paramCol1Row4);
            }
        }
        public IWebElement Col1Row5
        {
            get
            {
                return driver.FindElement(_paramCol1Row5);
            }
        }

        public IWebElement Col2Row1
        {
            get
            {
                return driver.FindElement(_paramCol2Row1);
            }
        }
        public IWebElement Col2Row2
        {
            get
            {
                return driver.FindElement(_paramCol2Row2);
            }
        }
        public IWebElement Col2Row3
        {
            get
            {
                return driver.FindElement(_paramCol2Row3);
            }
        }
        public IWebElement Col2Row4
        {
            get
            {
                return driver.FindElement(_paramCol2Row4);
            }
        }
        public IWebElement Col2Row5
        {
            get
            {
                return driver.FindElement(_paramCol2Row5);
            }
        }

        public IWebElement Col3Row1
        {
            get
            {
                return driver.FindElement(_paramCol3Row1);
            }
        }
        public IWebElement Col3Row2
        {
            get
            {
                return driver.FindElement(_paramCol3Row2);
            }
        }
        public IWebElement Col3Row3
        {
            get
            {
                return driver.FindElement(_paramCol3Row3);
            }
        }
        public IWebElement Col3Row4
        {
            get
            {
                return driver.FindElement(_paramCol3Row4);
            }
        }
        public IWebElement Col3Row5
        {
            get
            {
                return driver.FindElement(_paramCol3Row5);
            }
        }

        public IWebElement SearchOutputHeaderCheckBox
        {
            get
            {
                return driver.FindElement(_chkBoxSearchOutputHeader);
            }
        }
        public IWebElement SearchOutputTableData
        {
            get
            {
                return driver.FindElement(_tableSearchOutputData);
            }
        }
        public IWebElement TopDeleteButton
        {
            get
            {
                return driver.FindElement(_btnTopDelete);
            }
        }
        public IWebElement BottomDeleteButton
        {
            get
            {
                return driver.FindElement(_btnBottomDelete);
            }
        }
        public IWebElement PostDeleteMsg
        {
            get
            {
                return driver.FindElement(_msgPostDelete);
            }
        }
        #endregion

        #region Public methods
        public void VerifyPage()
        {
            Assert.AreEqual("Mass Delete: Contacts ~ Salesforce - Enterprise Edition", driver.Title);
            Assert.AreEqual("Step 1: Review what will happen when you mass delete your Contacts:", HeadStep1Text.Text);
            Assert.AreEqual("Step 2: Recommendation prior to mass deleting:", HeadStep2Text.Text);
            Assert.AreEqual("Step 3: Find Contacts that match the following criteria:", HeadStep3Text.Text);
            Assert.AreEqual("Permanently delete", HeadStep4Text.Text);
        }

        public void ClickOnSearchOutputHeaderCheckBox()
        {
            if (SearchOutputHeaderCheckBox.Displayed)
            {
                //SearchOutputHeaderCheckBox.Clear();
                SearchOutputHeaderCheckBox.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
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
                throw new Exception("Element is not found or not clickable");
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
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnHardDeleteCheckBox()
        {
            GetDisplayedElement(_chkBoxHardDelete, 500, 5000).Click();
        }
        public void SelectCol1Row1(string pCol1Row1)
        {
            IWebElement dropDownListBox = Col1Row1;
            SelectElement clickThis = new SelectElement(dropDownListBox);
            clickThis.SelectByText(pCol1Row1);
        }
        public void SelectCol1Row2(string pCol1Row2)
        {
            IWebElement dropDownListBox = Col1Row2;
            SelectElement clickThis = new SelectElement(dropDownListBox);
            clickThis.SelectByText(pCol1Row2);
        }
        public void SelectCol1Row3(string pCol1Row3)
        {
            IWebElement dropDownListBox = Col1Row3;
            SelectElement clickThis = new SelectElement(dropDownListBox);
            clickThis.SelectByText(pCol1Row3);
        }
        public void SelectCol1Row4(string pCol1Row4)
        {
            IWebElement dropDownListBox = Col1Row4;
            SelectElement clickThis = new SelectElement(dropDownListBox);
            clickThis.SelectByText(pCol1Row4);
        }
        public void SelectCol1Row5(string pCol1Row5)
        {
            IWebElement dropDownListBox = Col1Row5;
            SelectElement clickThis = new SelectElement(dropDownListBox);
            clickThis.SelectByText(pCol1Row5);
        }
        public void SelectCol2Row1(string pCol2Row1)
        {
            IWebElement dropDownListBox = Col2Row1;
            SelectElement clickThis = new SelectElement(dropDownListBox);
            clickThis.SelectByText(pCol2Row1);
        }
        public void SelectCol2Row2(string pCol2Row2)
        {
            IWebElement dropDownListBox = Col2Row2;
            SelectElement clickThis = new SelectElement(dropDownListBox);
            clickThis.SelectByText(pCol2Row2);
        }
        public void SelectCol2Row3(string pCol2Row3)
        {
            IWebElement dropDownListBox = Col2Row3;
            SelectElement clickThis = new SelectElement(dropDownListBox);
            clickThis.SelectByText(pCol2Row3);
        }
        public void SelectCol2Row4(string pCol2Row4)
        {
            IWebElement dropDownListBox = Col2Row4;
            SelectElement clickThis = new SelectElement(dropDownListBox);
            clickThis.SelectByText(pCol2Row4);
        }
        public void SelectCol2Row5(string pCol2Row5)
        {
            IWebElement dropDownListBox = Col1Row5;
            SelectElement clickThis = new SelectElement(dropDownListBox);
            clickThis.SelectByText(pCol2Row5);
        }
        public void EnterCol3Row1Data(string pCol3Row1)
        {
            GetDisplayedElement(_paramCol3Row1, 500, 15000).SendKeys(pCol3Row1);
        }
        public void EnterCol3Row2Data(string pCol3Row2)
        {
            GetDisplayedElement(_paramCol3Row2, 500, 15000).SendKeys(pCol3Row2);
        }
        public void EnterCol3Row3Data(string pCol3Row3)
        {
            GetDisplayedElement(_paramCol3Row3, 500, 15000).SendKeys(pCol3Row3);
        }
        public void EnterCol3Row4Data(string pCol3Row4)
        {
            GetDisplayedElement(_paramCol3Row4, 500, 15000).SendKeys(pCol3Row4);
        }
        public void EnterCol3Row5Data(string pCol3Row5)
        {
            GetDisplayedElement(_paramCol3Row5, 500, 15000).SendKeys(pCol3Row5);
        }
        public void ClickOnSearchButton()
        {
            if (SearchButton.Displayed)
            {
                SearchButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }

        public void ReturnTableData()
        {
            // xpath of html table
            var elemTable = driver.FindElement(_tableSearchOutputData);

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
                //Console.WriteLine(lstTrElem);
                strRowData = String.Empty;
            }
        }
        public void ConfirmDataDeletion()
        {
            if (PostDeleteMsg.Displayed)
            {
                Assert.AreEqual("No records to display.", PostDeleteMsg.Text);
            }
        }
        #endregion
    }
}
