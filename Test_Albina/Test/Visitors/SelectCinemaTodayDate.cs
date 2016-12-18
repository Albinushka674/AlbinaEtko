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
    public class SelectCinemaTodayDate : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            IWebElement dateDropDown = driver.FindElement(By.XPath("//select[@name='dt']"));
            dateDropDown.Click();

            SelectElement selectDate = new SelectElement(dateDropDown);
            selectDate.Options[1].Click();
        }

    }
}