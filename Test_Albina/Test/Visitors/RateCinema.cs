using System;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace Test.Visitors
{
    public class RateCinema : BaseVisitor
    {

        public void visit(IWebDriver driver)
        {
            IWebElement tapToSeeStars = driver.FindElement(By.XPath("//div[@name='(5) Masterpiece']"));
            tapToSeeStars.Click();

            Thread.Sleep(2000);

            IWebElement vote = tapToSeeStars.FindElement(By.XPath("//div[@class='star_full']"));
            vote.Click();

            //IWebElement tapToSeeStars = driver.FindElement(By.XPath("//div[@class='movie-rating-star enableTooltip clickable']"));
            //tapToSeeStars.Click();

            //IWebElement vote = driver.FindElement(By.XPath("//div[@class='eventStarRate5 star_full']"));
            //vote.Click();

            //IWebElement fullStartElement = driver.FindElement(By.XPath("//div[@name='(5) Masterpiece']"));
            //new Actions(driver).MoveToElement(fullStartElement, 0, 0);
            //fullStartElement.Click();
        }

    }
}