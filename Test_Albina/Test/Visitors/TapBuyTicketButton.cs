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
    public class TapBuyTicketButton : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            IWebElement buyTicketsButton = driver.FindElement(By.XPath("//button[@class='btn btn-primary  btn-block']"));
            buyTicketsButton.Click();
        }
        
    }
}