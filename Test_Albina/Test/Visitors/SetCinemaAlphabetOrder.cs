using System;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Visitors
{
    public class SetCinemaAlphabetOrder : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            IWebElement alpabetSortButton = driver.FindElement(By.XPath("//a[contains(@class, 'btn btn-link active')]"));

            alpabetSortButton.Click();
        }

    }
}