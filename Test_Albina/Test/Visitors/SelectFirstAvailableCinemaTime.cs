using System;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Visitors
{
    public class SelectFirstAvailableTime : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            IWebElement firstTime = driver.FindElement(By.XPath("//div[@class='panel-body times-inner']"));
            IWebElement chooseButton = firstTime.FindElement(By.XPath("//a[@class='btn btn-primary btn-sm pull-right']"));

            chooseButton.Click();
        }

    }
}