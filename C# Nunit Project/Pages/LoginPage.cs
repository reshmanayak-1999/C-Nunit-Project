using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Nunit_Project.Pages
{
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "loginButton")]
        private IWebElement LoginButton { get; set; }

        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void Login(string username, string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
            LoginButton.Click();
        }
    }
}
