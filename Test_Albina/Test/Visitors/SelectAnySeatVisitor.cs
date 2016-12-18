using System;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Test.Visitors
{
    public class SelectAnySeatVisitor : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            Thread.Sleep(2000);

            IWebElement confirmSeatsButton = driver.FindElement(By.XPath("//button[@class='btn btn-primary pull-right-sm']"));
            confirmSeatsButton.Click();
        }

    }
}