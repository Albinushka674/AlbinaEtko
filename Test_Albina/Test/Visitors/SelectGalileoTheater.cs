using System;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Visitors
{
    public class SelectGalileoTheater : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            IWebElement theatersDropDown = driver.FindElement(By.XPath("//selecta[@name='TheatreArea']"));

            theatersDropDown.Click();
            theatersDropDown.FindElement(By.CssSelector("option[value='1004']")).Click();
        }

    }
}