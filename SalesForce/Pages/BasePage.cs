using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System.Drawing.Imaging;

namespace SalesForce.Pages
{

    public class BasePage
    {
        /// <summary>
        /// Defining Constructor
        /// </summary>
        /// <param name="Driver"></param>
        public BasePage(IWebDriver Driver)
        {
            driver = Driver;
        }

        protected static IWebDriver driver;

        ///// <summary>
        ///// Current Page properties
        ///// </summary>
        //protected bool IsCurrentPage
        // {
        //  get
        //    {
        //      try
        //      {
        //          return CurrentPage();
        //      }
        //      catch (Exception)
        //      {

        //          throw;
        //      }
        //    }
        // }

        //protected abstract bool CurrentPage();
        /// <summary>
        /// Exception Handling
        /// </summary>
        /// <param name="type"></param>
        private void ThrowNotExpectedPageException(Type type)
        {
            throw new NotFoundException();
        }
        /// <summary>
        /// Find Element & wait
        /// </summary>
        /// <param name="by"></param>
        /// <param name="interval"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public IWebElement FindElement(By by, int interval = 500, int timeout = 15000)
        {
            IWebElement webelement = null;
            var tick = 0;
            try
            {
                do
                {
                    try
                    {
                        webelement = driver.FindElement(by);
                    }
                    catch (Exception)
                    {
                        Thread.Sleep(interval);
                        tick += interval;
                    }
                } while (webelement == null && tick < timeout);
                if (webelement == null)
                {
                    throw new TimeoutException(string.Format("Element(s) were not found within {0} secs",
                        (timeout / 1000).ToString()));
                }
                return webelement;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Wait for the element to be displayed or enabled. Find Element implemented
        /// </summary>
        /// <param name="by"></param>
        /// <param name="interval"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public IWebElement GetDisplayedElement(By by, int interval = 500, int timeout = 15000)
        {
            try
            {
                IWebElement element = FindElement(by, interval, timeout);
                if (element.Displayed)
                {
                    return element;
                }

                throw new ElementNotVisibleException();

            }
            catch (Exception)
            {

                throw new NoSuchElementException();
            }
        }
        //public IWebElement GetDataFromTable(string findText)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception)
        //    {

        //        throw new NoSuchElementException();
        //    }
        //}


        ///// <summary>
        ///// Capture Screenshot & save
        ///// </summary>
        ///// <param name="filename"></param>
        //public void takeScreenshot(String filename)
        //{
        //    ITakesScreenshot screenshotHandler = driver as ITakesScreenshot;
        //    Screenshot screenshot = screenshotHandler.GetScreenshot();
        //    screenshot.SaveAsFile(filename+"png", ScreenshotImageFormat.Png);
        //}
    }
}

