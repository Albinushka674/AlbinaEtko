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
    public class DismissAlert : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Dismiss();
        }
        
    }
}