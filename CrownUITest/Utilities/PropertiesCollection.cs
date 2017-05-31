using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CrownUITest.Pages
{
    class PropertiesCollection
    {
        //public static BasePage currentPage { get; set; }

        private static BasePage _currentPage;
        public static BasePage currentPage
        {
            get
            {
                return _currentPage;
            }
            set
            {
                ScenarioContext.Current["class"] = value;
                _currentPage = ScenarioContext.Current.Get<BasePage>("class");
            }
        }
    }
}