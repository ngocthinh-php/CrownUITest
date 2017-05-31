using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.Collections.Generic;
using OpenQA.Selenium.Chrome;

namespace MSTestProject1
{
    [TestClass]
    public class Salesforce
    {
        IWebDriver driver;

        [TestMethod]
        public void LogIn()
        {
            string title = driver.Title;
            Assert.AreEqual("Login | Salesforce", title);
            driver.FindElement(By.Id("username")).Clear();
            //driver.FindElement(By.Id("username")).SendKeys("jenachitta@hotmail.com");
            //driver.FindElement(By.Id("password")).Clear();
            //driver.FindElement(By.Id("password")).SendKeys("Data@1234");
            //driver.FindElement(By.Id("rememberUn")).Click();

            driver.FindElement(By.Id("username")).SendKeys("chitta.jena@crowncommercial.gov.uk.pemqa");
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("Data@2345");
            driver.FindElement(By.Id("rememberUn")).Click();

            driver.FindElement(By.Id("Login")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TestMethod]
        public void ManageUser()
        {

            LogIn();
            Assert.AreEqual("Home", driver.FindElement(By.LinkText("Home")).Text);
            driver.FindElement(By.Id("userNavLabel")).Click();
            driver.FindElement(By.Id("setupLink")).Click();
            driver.FindElement(By.Id("Users_font")).Click();
            //Assert.AreEqual("Manage Users : Developer Edition ~ Salesforce - Developer Edition", driver.Title);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.Id("ManageUsers_font")).Click();
            //driver.FindElement(By.XPath("//*[@id='ManageUsers_font']")).Click();

            //-------------------------------------------------------------------------------------------------------
            //Handle Hidden objects
            //-------------------------------------------------------------------------------------------------------
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement hiddenLink = driver.FindElement(By.XPath("//*[@id='ManageUsers_font']"));
            String script = "arguments[0].click();";
            js.ExecuteScript(script, hiddenLink);
            //-------------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Assert.AreEqual("New User", driver.FindElement(By.Name("new")).GetAttribute("value"));
            Assert.AreEqual("Reset Password(s)", driver.FindElement(By.Name("resetPW")).GetAttribute("value"));
            Assert.AreEqual("Add Multiple Users", driver.FindElement(By.Name("addUsers")).GetAttribute("value"));
            string ptitle = driver.Title;
            Assert.AreEqual("All Users ~ Salesforce - Developer Edition", ptitle);

            driver.FindElement(By.LinkText("Home")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TestInitialize]
        public void Setup()
        {
            //Start Browser and open URL
            //driver = new FirefoxDriver();
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("https://login.salesforce.com/");
            driver.Navigate().GoToUrl("https://crowncommercial--pemqa.cs83.my.salesforce.com/");
        }
        [TestCleanup]
        public void CleanupTest()
        {
            //Close Browser
            userLogout();
            driver.Quit();
        }

        private void userLogout()
        {
            driver.FindElement(By.Id("userNavLabel")).Click();
            driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}
