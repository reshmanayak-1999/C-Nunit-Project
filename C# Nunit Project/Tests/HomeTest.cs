using C__Nunit_Project.Pages;
using C__Nunit_Project.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Nunit_Project.Tests
{
    public class HomeTest : Base
    {
        private ConfigReader data;
        private string username;
        private string password;
        [Test]
      public void HomePageTest()
        {
            data = new ConfigReader();
            username = data.GetConfig().Username;
            password = data.GetConfig().Password;
            driver.Navigate().GoToUrl(data.GetConfig().Baseurl);
            LoginPage loginPage = new LoginPage(driver);

            // Act
            loginPage.Login(username, password);
            HomePage homePage = new HomePage(driver);
            homePage.SearchProduct("shoe");
            homePage.AddProductToCart();
            homePage.ClickOnCheckout();
        }
        
         
    }
}
