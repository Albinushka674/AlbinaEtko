using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test.Visitors
{
    public class EnterCinemaToFind : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            IWebElement queyField = driver.FindElement(By.Name("query"));
            queyField.SendKeys("Моана");

            Thread.Sleep(2000);

            IWebElement buttonContainer = driver.FindElement(By.Id("global-search-container"));
            IWebElement searchButton = buttonContainer.FindElement(By.XPath("//div[@class='input-group-btn']"));
            searchButton.Click();
        }

    }
}
