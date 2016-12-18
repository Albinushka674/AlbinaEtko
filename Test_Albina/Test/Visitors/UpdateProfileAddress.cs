using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test.Visitors
{
    public class UpdateProfileAddress : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            IWebElement addressLine = driver.FindElement(By.Id("inputAddressLine1"));
            string value = addressLine.Text;
            addressLine.SendKeys(value + "1");
        }

    }
}
