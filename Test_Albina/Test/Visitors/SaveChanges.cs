﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test.Visitors
{
    public class SaveChanges : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scroll(0, 1000)", new object[0]);

            Thread.Sleep(1000);

            IWebElement submitButton = driver.FindElement(By.XPath("//button[@class='btn btn-primary']/descendant::span[contains(text(),'Сохранить профиль')]"));
            submitButton.Click();
        }

    }
}
