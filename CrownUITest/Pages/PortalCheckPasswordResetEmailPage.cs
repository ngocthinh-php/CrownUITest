namespace CrownUITest.Pages
{
    #region Using Directives
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OpenQA.Selenium;
    using NUnit.Framework;
    using OpenQA.Selenium.Support.UI;
    using System.Threading;
    #endregion

    public class PortalCheckPasswordResetEmailPage : BasePage
    {
        #region Constructor
        public PortalCheckPasswordResetEmailPage(IWebDriver driver) : base(driver) { }
        #endregion

        #region Properties and fields
        
        protected override bool CurrentPage()
        {
            try
            {
                return PageTitle.Displayed;
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }

        }

        private By _PageTitle = By.XPath("//*[@id='LoginNew']");
        public IWebElement PageTitle
        {
            get
            {
                return driver.FindElement(_PageTitle);
            }
        }

        #endregion

        #region Public methods
        public void VerifyPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("h1.bold-large")));
            //Assert.IsTrue(PageTitle.Displayed);
            Assert.AreEqual("We've sent an email to your registered account.", driver.FindElement(By.CssSelector("h1.bold-large")).Text);
            Assert.AreEqual("What happens next", driver.FindElement(By.CssSelector("h2.heading-medium")).Text);
            Assert.AreEqual("Please click on the \"Reset my password\" link in the email we've just sent you. If it hasn't arrived within 15 minutes, please check your spam folder.", driver.FindElement(By.XPath("//div[@id='content']/div/div/div[2]/p[2]")).Text);

        }
        #endregion
    }
}