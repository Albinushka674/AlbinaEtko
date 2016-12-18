using System;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Visitors
{
    public class SetCinemaDateOrder : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            IWebElement dateSortButton = driver.FindElement(By.XPath("//a[@class='btn btn-link']"));

            dateSortButton.Click();
        }

    }
}