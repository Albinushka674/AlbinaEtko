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
    public class CinamArenaCity : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            if (driver.Url.EndsWith("/MovieTheaters/ArenaCity"))
            {
                return;
            }

            IWebElement theatersButton = driver.FindElement(By.XPath("//a[contains(text(), 'Кинотеатры ')]"));
            theatersButton.Click();

            Thread.Sleep(100);

            IWebElement theatersMenuDropDown = driver.FindElement(By.XPath("//li[contains(@class,'SubMenuNode_1517 dropdown')]"));

            IWebElement ticketsInSoldButton = theatersMenuDropDown.FindElement(By.XPath("//li[@class=' SubMenuNode_1536 ']"));
            ticketsInSoldButton.Click();
        }

    }
}