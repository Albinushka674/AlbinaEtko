using System;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Visitors
{
    public class SelectFirstCinema : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            IWebElement firstCinema = driver.FindElement(By.XPath("//div[@class='panel panel-default']"));
            IWebElement cinemaImage = firstCinema.FindElement(By.XPath("//div[@class='image-cover']"));

            cinemaImage.Click();
        }

    }
}