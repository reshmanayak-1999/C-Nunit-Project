using C__Nunit_Project.Pages;
using C__Nunit_Project.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Nunit_Project.Tests
{

 
    
    public class LoginTest : Base
    {
       private  ConfigReader data;
        private string username;
        private string password;
        [Test]
        public void TestLogin()
        {

            IWebDriver driver = new ChromeDriver();
             data = new ConfigReader();
             username = data.GetConfig().Username;
             password = data.GetConfig().Password;
        driver.Navigate().GoToUrl(data.GetConfig().Baseurl);
            LoginPage loginPage = new LoginPage(driver);
            // Act
            loginPage.Login(username, password);
            // Assert
            //Assert.IsTrue(driver.Url.Contains("dashboard"));
            // Cleanup
            driver.Quit();

           

        }
    }
}
