using System;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Visitors
{
    public class SetCinemaOrderAscending : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            IWebElement orderInput = driver.FindElement(By.Id("orderInput"));
            var value = orderInput.GetAttribute("value");

            if (value == "" || orderInput.GetAttribute("value") == "asc")
            {
                IWebElement filterButton = driver.FindElement(By.XPath("//a[contains(@class, 'glyphicon glyphicon-sort-by-attributes-alt order-icon')]"));
                filterButton.Click();
            }
        }

    }
}