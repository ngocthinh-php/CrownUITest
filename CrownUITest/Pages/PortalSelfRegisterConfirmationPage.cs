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


    public class PortalSelfRegisterConfirmationPage : BasePage
    {
        #region Constructor
        public PortalSelfRegisterConfirmationPage(IWebDriver Driver) : base(Driver) { }
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
            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            // wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='bold-large']")));
            Thread.Sleep(5000);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@class='bold-large']")).Displayed);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@class='heading-medium']")).Displayed);
            // Assert.AreEqual("Thank you for registering", driver.FindElement(By.XPath("//*[@class='bold-large']")).Text);
           // Assert.AreEqual("We've sent you an email so you can validate your account", driver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p")).Text);
           // Assert.AreEqual("What happens next", driver.FindElement(By.XPath("//*[@class='heading-medium']")).Text);
          //  Assert.AreEqual("Please validate your account by clicking on the link in the email we've just sent you. If it hasn't arrived within 15 minutes, please check your spam folder.", driver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/p[2]")).Text);
           // Assert.AreEqual("If you've any problems, please give us a call on 0345 410 2222.", driver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/p[3]")).Text);
        }
        #endregion

    }
}
