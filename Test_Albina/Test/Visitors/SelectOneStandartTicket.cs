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
    public class SelectOneStandartTicket : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            IWebElement ticketsDropDown = driver.FindElement(By.Id("ShowPrices0Amount"));
            ticketsDropDown.Click();

            SelectElement selectTicket = new SelectElement(ticketsDropDown);
            selectTicket.Options[1].Click();
        }

    }
}