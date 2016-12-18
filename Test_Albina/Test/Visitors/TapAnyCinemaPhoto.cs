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
    public class TapAnyCinemaPhoto : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, 1000)", new object[0]);

            Thread.Sleep(1000);

            IWebElement anyImage = driver.FindElement(By.XPath("//a[@href='https://i.gyazo.com/9228832ff7d49b7638e99725863c7bbd.png']"));
            anyImage.Click();
        }

    }
}