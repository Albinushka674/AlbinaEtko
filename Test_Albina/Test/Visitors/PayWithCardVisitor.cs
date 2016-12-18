using System;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Test.Visitors
{
    public class PayWithCardVisitor : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            IWebElement payWithCardButton = driver.FindElement(By.Id("BeginPaymentActiveButton"));
            payWithCardButton.Click();
        }

    }
}