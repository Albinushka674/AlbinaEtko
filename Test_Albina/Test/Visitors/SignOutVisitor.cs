using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test.Visitors
{
    public class SignOutVisitor : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            //IWebElement element = driver.FindElement(By.Id("wrapper-for-fixed-bg"));
            IWebElement signOutMenuButton = driver.FindElement(By.XPath("//a[contains(@class, 'dropdown-toggle navbar-link')]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, -1000)", new object[0]);

            Thread.Sleep(2500);

            signOutMenuButton.Click();

            IWebElement signOutButton = driver.FindElement(By.XPath("//*[contains(text(), ' Выйти')]"));
            signOutButton.Click();
        }

    }
}
