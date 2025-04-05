using C__Nunit_Project.Pages;
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
        // private static IWebDriver driver;
        [Test]
      public void HomePageTest()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login();
        }
        
         
    }
}
