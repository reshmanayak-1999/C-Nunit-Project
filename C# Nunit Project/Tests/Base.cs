using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Nunit_Project.Tests
{
    public class Base
    {
        public IWebDriver driver;
        [SetUp]
        public void Init() {
             driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://crio-qkart-frontend-qa.vercel.app/login");
            driver.Manage().Window.Maximize();

        }
        [TearDown]
        public void Cleanup()
        {
            driver.Dispose();
        }
    }
}
