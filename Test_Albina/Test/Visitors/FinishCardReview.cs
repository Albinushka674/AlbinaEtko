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
    public class FinishCardReview : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            Thread.Sleep(3000);

            driver.Close();
        }
        
    }
}