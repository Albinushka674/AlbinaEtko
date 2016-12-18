using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Visitors
{
    public class IsSignedInVisitor : BaseVisitor
    {

        private static string CURRENT_USERNAME = "Альбина Етко";

        public void visit(IWebDriver driver)
        {
            IWebElement signOutMenuButton = driver.FindElement(By.XPath("//a[contains(@class, 'dropdown-toggle navbar-link')]"));

            if (signOutMenuButton.Text != IsSignedInVisitor.CURRENT_USERNAME)
            {
                throw new InvalidElementStateException();
            }
        }

    }
}
