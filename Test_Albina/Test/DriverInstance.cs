using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System.IO;

namespace Test
{
    public class DriverInstance
    {
        private static IWebDriver driver;
        public static string GetFilesDirectory()
        {
            return Path.GetFullPath(@"Test\Res\");
        }
        public static IWebDriver GetInstance()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
                driver.Manage().Window.Maximize();
            }

            return driver;
        }

        public static void CloseBrowser()
        {
            driver.Quit();
            driver = null;
        }
    }
}