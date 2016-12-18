using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test.Visitors
{
    public class SaveChanges : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, 1000)", new object[0]);

            Thread.Sleep(2500);

            IWebElement submitButton = driver.FindElement(By.XPath("//button[@type='submit']"));
            submitButton.Click();
        }

    }
}
