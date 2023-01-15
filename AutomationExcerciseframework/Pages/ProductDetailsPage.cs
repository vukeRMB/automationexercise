using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExcerciseframework.Pages
{
    class ProductDetailsPage
    {
        readonly IWebDriver _driver;
        public By page = By.ClassName("product-details");
        public By addBtn = By.CssSelector(".product-information .btn");
        public By viewCart = By.XPath("//*[@id=cartModal ]//a");
        public By productName



        public By prodName = By.XPath("//*")

        public ProductDetailsPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            
                
        }

    }
}
