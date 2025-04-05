using C__Nunit_Project.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Nunit_Project.Tests
{
    public class LoginTest
    {
        [Test]
        public void TestLogin()
        {
            // Arrange
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://crio-qkart-frontend-qa.vercel.app/login");
            LoginPage loginPage = new LoginPage(driver);
            // Act
            loginPage.Login("Admin10000", "Admin10000");
            // Assert
            //Assert.IsTrue(driver.Url.Contains("dashboard"));
            // Cleanup
            driver.Quit();
        }
    }
}
