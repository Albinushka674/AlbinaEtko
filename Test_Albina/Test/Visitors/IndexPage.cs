using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Remote;

namespace Test.pages
{
    public class IndexPage : AbstractPage
    {

        private const string BASE_URL = "http://silverscreen.by/";

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'btn-login btn btn-primary popover-link hidden-xs hidden-sm')]")]
        private IWebElement enterButton;
        
        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'userName')]")]
        private IWebElement usernameField;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'password')]")]
        private IWebElement passwordField;

        [FindsBy(How = How.XPath, Using = "//button[contains(@type, 'submit')]")]
        private IWebElement submitButton;

        [FindsBy(How = How.XPath, Using = "//a[contains(@class, 'dropdown-toggle navbar-link')]")]
        private IWebElement signOutMenuButton;

        [FindsBy(How = How.XPath, Using = "//*[contains(text(), ' Выйти')]")]
        private IWebElement signOutButton;

        [FindsBy(How = How.XPath, Using = "//*[contains(text(), 'Афиша ')]")]
        private IWebElement afishaButton;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, '/Movies/NowInTheatres')]")]
        private IWebElement ticketsInSoldButton;

        [FindsBy(How = How.XPath, Using = "//select[contains(@name, 'TheatreArea')]")]
        private IWebElement theatersDropDownButton;

        [FindsBy(How = How.XPath, Using = "//select[contains(@name, 'genre')]")]
        private IWebElement genreDropDownButton;

        [FindsBy(How = How.XPath, Using = "//a[contains(@class, 'btn btn-link active')]")]
        private IWebElement alpabetSortButton;

        [FindsBy(How = How.XPath, Using = "//form[contains(@class, '')]")]
        private IWebElement rootForm;

        [FindsBy(How = How.Id, Using = "orderInput")]
        private IWebElement orderInput;

        private string userName = "albinushka674";

        private string password = "qazwsx12345";

        private string currentUsername = "Альбина Етко";

        public IndexPage(IWebDriver driver) : base(driver)
        {
            driver.Navigate().GoToUrl(IndexPage.BASE_URL);
        }

        public Boolean signedIn
        { 
            get
            {
                return this.signOutMenuButton.Text == this.currentUsername;
            }
        }

        public void SignIn()
        {
            this.enterButton.Click();
            this.usernameField.SendKeys(userName);
            this.passwordField.SendKeys(password);
            this.submitButton.Click();
        }

        public void SignOut()
        {
            this.signOutMenuButton.Click();
            this.signOutButton.Click();
        }

        public void tapAfishaTickets()
        {
            if (this.driver.Url.EndsWith("/Movies/NowInTheatres"))
            {
                return;
            }

            this.afishaButton.Click();
            this.ticketsInSoldButton.Click();
            this.theatersDropDownButton.Click();
            this.theatersDropDownButton.FindElement(By.CssSelector("option[value='1004']")).Click();
        }

        public void tapGenreAndDramma()
        {
            this.genreDropDownButton.Click();
            this.genreDropDownButton.FindElement(By.CssSelector("option[value='1093']")).Click();
        }

        public void filterAscending()
        {
            IWebElement filterButton = this.driver.FindElement(By.XPath("//a[contains(@class, 'glyphicon glyphicon-sort-by-attributes-alt order-icon')]"));
            var value = this.orderInput.GetAttribute("value");
            if (value == "" || this.orderInput.GetAttribute("value") == "asc")
            {
                filterButton.Click();
            }
        }

        public void filterDescending()
        {
            IWebElement filterButton = this.driver.FindElement(By.XPath("//a[contains(@class, 'glyphicon glyphicon-sort-by-attributes-alt order-icon')]"));
            var value = this.orderInput.GetAttribute("value");
            if (value == "desc")
            {
                filterButton.Click();
            }
        }

        public void alphabetFilter()
        {
            this.alpabetSortButton.Click();
        }

    }
}
