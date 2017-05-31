using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace CrownUITest.Pages
{
    public class PopUP : BasePage
    {
        public PopUP(IWebDriver Driver) : base(Driver)
        {
        }
        private By _PopupTitle = By.LinkText("");
        private By _btnSave = By.Name("Save");
        private By _btnNever = By.Name("Never");

        public IWebElement PageTitle
        {
            get
            {
                return driver.FindElement(_PopupTitle);
            }

        }
        public IWebElement SaveBtn
        {
            get
            {
                return driver.FindElement(_btnSave);
            }

        }
        public IWebElement NeverBtn
        {
            get
            {
                return driver.FindElement(_btnNever);
            }

        }
        public void ClickOnBtn()
        {

        }
        protected override bool CurrentPage()
        {
            throw new NotImplementedException();
        }


    }
}
