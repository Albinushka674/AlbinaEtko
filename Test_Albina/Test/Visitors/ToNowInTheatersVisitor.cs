using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Visitors
{
    public class ToNowInTheatersVisitor : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            if (driver.Url.EndsWith("/Movies/NowInTheatres"))
            {
                return;
            }
            
            IWebElement afishaButton = driver.FindElement(By.XPath("//*[contains(text(), 'Афиша ')]"));

            afishaButton.Click();

            IWebElement ticketsInSoldButton = driver.FindElement(By.XPath("//a[contains(@href, '/Movies/NowInTheatres')]"));
            ticketsInSoldButton.Click();

            IWebElement theatersDropDownButton = driver.FindElement(By.XPath("//select[contains(@name, 'TheatreArea')]"));
            theatersDropDownButton.Click();
            theatersDropDownButton.FindElement(By.CssSelector("option[value='1004']")).Click();
        }

    }
}
