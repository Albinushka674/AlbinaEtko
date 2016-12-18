using System;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Test.Visitors
{
    public class SelectCardVisitor : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            IWebElement visaGoldLiveButton = driver.FindElement(By.XPath("//input[@alt='Visa Gold LIVE']"));
            visaGoldLiveButton.Click();
        }
        
    }
}