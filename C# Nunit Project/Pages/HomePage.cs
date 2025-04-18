﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Nunit_Project.Pages
{
    class HomePage
         
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        // Page Elements
        [FindsBy(How = How.XPath, Using = "(//input[@name='search'])[1]")]
        private IWebElement txtSearchBox;

        [FindsBy(How = How.XPath, Using = "(//input[@name='search']/../div)[1]")]
        private IWebElement btnSearch;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Add to cart')]")]
        private IWebElement btnAddToCart;
        // Search product
        public void SearchProduct(string productName)
        {
            txtSearchBox.SendKeys(productName);
            btnSearch.Click();
        }
        public void AddProductToCart()
        {
            btnAddToCart.Click();
        }
    }

}
