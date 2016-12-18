using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test.Visitors
{
    public class SignInVisitor : BaseVisitor
    {

        private static string USER_NAME = "albinushka674";

        private static string PASSWORD = "qazwsx12345";

        public void visit(IWebDriver driver)
        {
            IWebElement enterButton = driver.FindElement(By.XPath("//div[contains(@class, 'btn-login btn btn-primary popover-link hidden-xs hidden-sm')]"));

            enterButton.Click();

            Thread.Sleep(50);

            IWebElement usernameField = driver.FindElement(By.Id("userName"));
            IWebElement passwordField = driver.FindElement(By.Id("password"));
            IWebElement submitButton = driver.FindElement(By.XPath("//button[contains(@type, 'submit')]"));

            usernameField.SendKeys(SignInVisitor.USER_NAME);
            passwordField.SendKeys(SignInVisitor.PASSWORD);
            submitButton.Click();
        }

    }
}
