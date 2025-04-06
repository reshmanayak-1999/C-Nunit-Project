using Allure.NUnit.Attributes;
using Allure.NUnit;
using C__Nunit_Project.Pages;
using C__Nunit_Project.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Allure.Commons;

namespace C__Nunit_Project.Tests
{
    [AllureNUnit]
    [AllureSuite("Login Tests")]
    public class LoginTest : Base
    {
        private ConfigReader data;
        private string username;
        private string password;
        [Test]
        [AllureTag("TC-001")]
        [AllureSeverity((Allure.Net.Commons.SeverityLevel)Allure.Commons.SeverityLevel.critical)] // Updated this line
        [AllureOwner("Sainma")]
        [AllureFeature("Login")]
        public void TestLogin()
        {
            data = new ConfigReader();
            username = data.GetConfig().Username;
            password = data.GetConfig().Password;
            driver.Navigate().GoToUrl(data.GetConfig().Baseurl);
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login(username, password);
            driver.Quit();
        }
    }
}
