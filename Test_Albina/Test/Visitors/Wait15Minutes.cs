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
    public class Wait15Minutes : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            Thread.Sleep(15 * 60 * 1000);
        }
        
    }
}