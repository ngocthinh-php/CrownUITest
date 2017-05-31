using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using CrownUITest.PageProperties.Enums;
using System.Threading;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;

namespace CrownUITest.Pages
{

    public class PortalHomePage: BasePage
    {
        public PortalHomePage(IWebDriver driver) : base(driver){ }

        #region Properties & fields
        private By _PageTitle = By.LinkText("portal");
        private By _typeSearchField = By.XPath("//*[@id='251:0']");
        private By _btnSearch = By.XPath("//*[@id='header']/div[1]/div[2]/div/div/div/div[2]/form/div/span/button[1]");

        private readonly Dictionary<PortalHomeHeaderActions, By> _headeractionlinks =  new Dictionary<PortalHomeHeaderActions, By>{
            {
                    PortalHomeHeaderActions.AboutUs, By.XPath(".//*[@id='NapiliCommunityTemplate']/div[1]/div[2]/div/div[1]/div/div/div/span[1]/a")
                },
             {
                    PortalHomeHeaderActions.ContactUs, By.XPath(".//*[@id='NapiliCommunityTemplate']/div[1]/div[2]/div/div[1]/div/div/div/span[3]/a")
                },
              {
                    PortalHomeHeaderActions.HelpAndSupport, By.XPath(".//*[@id='NapiliCommunityTemplate']/div[1]/div[2]/div/div[1]/div/div/div/span[2]/a")
                }
            };

        private readonly Dictionary<PortalHomeActionLinks, By> _actionlinks = new Dictionary<PortalHomeActionLinks, By>{
            {
                PortalHomeActionLinks.LatestNews,By.Id("")
            },
             {
                PortalHomeActionLinks.QuickLink,By.Id("")
            }
            };
        private readonly Dictionary<PortalHomeNavigationBar, By> _homenavigationlinks = new Dictionary<PortalHomeNavigationBar, By>{
            {
                PortalHomeNavigationBar.BecomeASupplier,By.LinkText("Become a supplier")
            },
             {
                PortalHomeNavigationBar.FindAFramework,By.LinkText("Find a framework")
            },
              {
                PortalHomeNavigationBar.FindASupplier,By.LinkText("Find a supplier")
            },
               {
                PortalHomeNavigationBar.HowToBuy,By.LinkText("How to buy")
            },
                {
                PortalHomeNavigationBar.LatestNews,By.LinkText("Latest news")
            },
                 {
                PortalHomeNavigationBar.LatestOpportunities,By.LinkText("Latest opportunities")
            }
            };

        #endregion

        public IWebElement GetPortalHomeHeaderActions(PortalHomeHeaderActions key)
        {
            return driver.FindElement(_headeractionlinks[key]);
        }
        public IWebElement GetPortalHomeActionLinks(PortalHomeActionLinks key)
        {
            return driver.FindElement(_actionlinks[key]);
        }
        public IWebElement GetPortalHomeNavigationLinks(PortalHomeNavigationBar key)
        {
            return driver.FindElement(_homenavigationlinks[key]);
        }
        public void VerifyNavigationLinks()
        {
            Assert.IsTrue(GetPortalHomeNavigationLinks(PortalHomeNavigationBar.BecomeASupplier).Displayed);
            Assert.IsTrue(GetPortalHomeNavigationLinks(PortalHomeNavigationBar.FindAFramework).Displayed);
            Assert.IsTrue(GetPortalHomeNavigationLinks(PortalHomeNavigationBar.FindASupplier).Displayed);
            Assert.IsTrue(GetPortalHomeNavigationLinks(PortalHomeNavigationBar.HowToBuy).Displayed);
            Assert.IsTrue(GetPortalHomeNavigationLinks(PortalHomeNavigationBar.LatestNews).Displayed);
            Assert.IsTrue(GetPortalHomeNavigationLinks(PortalHomeNavigationBar.LatestOpportunities).Displayed);
          
        }
        public void VerifyHeaders()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(GetPortalHomeHeaderActions(PortalHomeHeaderActions.AboutUs).Displayed);
            Assert.IsTrue(GetPortalHomeHeaderActions(PortalHomeHeaderActions.ContactUs).Displayed);
            Assert.IsTrue(GetPortalHomeHeaderActions(PortalHomeHeaderActions.HelpAndSupport).Displayed);
        }

        public IWebElement PageTitle
        {
            get
            {
                return driver.FindElement(_PageTitle);
            }

        }
        public void VerifyPage()
        {
            Assert.IsTrue(PageTitle.Displayed);
        }
        public IWebElement SearchText
        {
            get
            {
                //return driver.FindElement(_typeSearchField);
                return GetDisplayedElement(_typeSearchField, 500, 15000);
            }
        }
        public IWebElement SearchBtn
        {
            get
            {
                return driver.FindElement(_btnSearch);
            }

        }
        public void UserSearch(string inputText)
        {
            SearchText.SendKeys(inputText);
            SearchBtn.Click();
        }
        public void CanSearchByTextBox()
        {
            Assert.IsTrue(SearchText.Displayed);
            SearchText.Clear();
            SearchText.SendKeys("supplier");
            GetDisplayedElement(_btnSearch, 500, 15000).Click();
        }
        public void sampletest()
        {
            Assert.AreEqual("Home", driver.Title);
            Assert.AreEqual("portal", driver.FindElement(By.LinkText("portal")).Text);
            Assert.AreEqual("Help & support", driver.FindElement(By.LinkText("Help & support")).Text);
            Assert.AreEqual("Contact us", driver.FindElement(By.LinkText("Contact us")).Text);
            Assert.IsTrue(driver.FindElement(By.Id("251:0")).Displayed);
            //Assert.IsTrue(IsElementPresent(By.XPath("//button[@type='button']")));
            //Assert.IsTrue(IsElementPresent(By.XPath("(//button[@type='button'])[4]")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("How to buy")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Find a framework")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Find a supplier")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Latest opportunities")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Become a supplier")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Latest news")));
            //Assert.AreEqual("Quick Links", driver.FindElement(By.CssSelector("h4")).Text);
            //Assert.IsTrue(IsElementPresent(By.CssSelector("h5")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Purchasing platform")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("eMarketplace")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Digital Marketplace")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Energy portal")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Fleet portal")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Travel portal")));
            //Assert.AreEqual("Suppliers", driver.FindElement(By.CssSelector("h5.marginTop10")).Text);
            //Assert.IsTrue(IsElementPresent(By.LinkText("Contracts Finder")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("eSourcing")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("MISO")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("CCS Events")));
            //Assert.AreEqual("Welcome to the Crown Commercial Service", driver.FindElement(By.CssSelector("h3")).Text);
            //Assert.AreEqual("Read more about how to buy goods and services through us.", driver.FindElement(By.XPath("//div[@id='NapiliCommunityTemplate']/div[4]/div/div[2]/div/div/div[2]/div/div/p[3]")).Text);
            //Assert.IsTrue(IsElementPresent(By.XPath("//div[@id='NapiliCommunityTemplate']/div[4]/div/div[2]/div/div/div[3]/div/div/h3")));
            //Assert.AreEqual("Buildings", driver.FindElement(By.CssSelector("a > strong")).Text);
            //Assert.IsTrue(IsElementPresent(By.LinkText("Facilities Menagement")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Property")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("UK Shared Business Services")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Utilities & Fuels")));
            //Assert.IsTrue(IsElementPresent(By.XPath("//div[@id='NapiliCommunityTemplate']/div[4]/div/div[2]/div/div/div[3]/div/div/div/div[2]/p/a/strong")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Communications")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Finance, Planning & Estates")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Financial Services")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Fleet")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("MFD & Document management")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Office Solutions")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Travel")));
            //Assert.IsTrue(IsElementPresent(By.XPath("//div[@id='NapiliCommunityTemplate']/div[4]/div/div[2]/div/div/div[3]/div/div/div/div[3]/p/a/strong")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Advisory Services")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Finance/Technical Services")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Health")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Human Resources")));
            //Assert.IsTrue(IsElementPresent(By.XPath("//div[@id='NapiliCommunityTemplate']/div[4]/div/div[2]/div/div/div[3]/div/div/div/div[4]/p/a/strong")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Cloud & Digital")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Network Services")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Software Licensing")));
            //Assert.IsTrue(IsElementPresent(By.LinkText("Services")));
            //Assert.AreEqual("Who we work with", driver.FindElement(By.XPath("//div[@id='NapiliCommunityTemplate']/div[4]/div/div[2]/div/div/div[4]/div/div/h3")).Text);
            //Assert.IsTrue(IsElementPresent(By.XPath("//div[@id='NapiliCommunityTemplate']/div[4]/div/div[2]/div/div/div[4]/div/div/div/div/p/a/strong")));
            //Assert.IsTrue(IsElementPresent(By.XPath("//div[@id='NapiliCommunityTemplate']/div[4]/div/div[2]/div/div/div[4]/div/div/div/div[2]/p/a/strong")));
            //Assert.IsTrue(IsElementPresent(By.XPath("//div[@id='NapiliCommunityTemplate']/div[4]/div/div[2]/div/div/div[4]/div/div/div/div[3]/p/a/strong")));
            //Assert.IsTrue(IsElementPresent(By.XPath("//div[@id='NapiliCommunityTemplate']/div[4]/div/div[2]/div/div/div[4]/div/div/div/div[4]/p/a/strong")));
            //Assert.IsTrue(IsElementPresent(By.XPath("//div[@id='NapiliCommunityTemplate']/div[4]/div/div[2]/div/div/div[4]/div/div/div[2]/div/p/a/strong")));
            //Assert.IsTrue(IsElementPresent(By.XPath("//div[@id='NapiliCommunityTemplate']/div[4]/div/div[2]/div/div/div[4]/div/div/div[2]/div[2]/p/a/strong")));
            //Assert.IsTrue(IsElementPresent(By.XPath("//div[@id='NapiliCommunityTemplate']/div[4]/div/div[2]/div/div/div[4]/div/div/div[2]/div[3]/p/a/strong")));
            //Assert.IsTrue(IsElementPresent(By.XPath("//div[@id='NapiliCommunityTemplate']/div[4]/div/div[2]/div/div/div[4]/div/div/div[2]/div[4]/p/a/strong")));
            //Assert.IsTrue(IsElementPresent(By.XPath("//div[@id='NapiliCommunityTemplate']/div[4]/div/div[2]/div/div/div[4]/div/div/div[3]/div/p/a/strong")));
            //Assert.IsTrue(IsElementPresent(By.CssSelector("h3 > strong")));
            //Assert.IsTrue(IsElementPresent(By.CssSelector("img..profileIcon")));
        }
        protected override bool CurrentPage()
        {
            throw new NotImplementedException();
        }

    }
}
