using System;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace Test.Visitors
{
    public class RateCinema : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            IWebElement fullStartElement = driver.FindElement(By.XPath("//div[@name='(5) Masterpiece']"));
            //new Actions(driver).MoveToElement(fullStartElement, 0, 0);
            fullStartElement.Click();
        }

    }
}