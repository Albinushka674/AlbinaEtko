using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Test.Visitors
{
    public interface BaseVisitor
    {

        void visit(IWebDriver driver);

    }
}