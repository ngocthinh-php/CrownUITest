using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;


namespace CrownUITest.Utilities
{
    class LoadCookiesData
    {
        //package com.avactis.test.handleCookie

        //public class LoadCookiesData
        //{
        //    staticWebDriver driver;
        //    public static void main(String[] args)
        //    {
        //        System.setProperty("webdriver.chrome.driver", "/OnlineShopping/InputData/chromedriver.exe");
        //        driver = new ChromeDriver();
        //        try
        //        {

        //            File file = new File("Cookies.data");
        //            FileReader fileReader = new FileReader(file);
        //            BufferedReader Buffreader = new BufferedReader(fileReader);
        //            String strline;
        //            while ((strline = Buffreader.readLine()) != null)
        //            {
        //                String Tokenizertoken = newStringTokenizer(strline, ";");
        //                while (token.hasMoreTokens())
        //                {
        //                    String name = token.nextToken();
        //                    String value = token.nextToken();
        //                    String domain = token.nextToken();
        //                    String path = token.nextToken();
        //                    Date expiry = null;

        //                    String val;
        //                    if (!(val = token.nextToken()).equals("null"))
        //                    {
        //                        expiry = new Date(val);
        //                    }
        //                    Boolean isSecure = new Boolean(token.nextToken()).
        //                    booleanValue();
        //                    Cookie ck = new Cookie(name, value, domain, path, expiry, isSecure);
        //                    driver.manage().addCookie(ck); // This will add the stored cookie to your current session					
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            ex.printStackTrace();
        //        }
        //        driver.get("http://demo.avactis.com/4.7.9/");
        //    }
        }
}