using System;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Visitors
{
    public class CartoonGenreVisitor : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            IWebElement genreDropDownButton = driver.FindElement(By.XPath("//select[contains(@name, 'genre')]"));

            genreDropDownButton.Click();
            genreDropDownButton.FindElement(By.CssSelector("option[value='1102']")).Click();
        }

    }
}