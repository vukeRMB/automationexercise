﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExcerciseframework.Pages
{
    class SignupPage
    {
        public IWebDriver _driver;
        public By signupPage = By.XPath("//*[@class='login-form']//*[contains(text(),'Enter Account Information')]");
        public By password = By.Id("password");
        public By firstName = By.Id("first_name");
        public By lastname = By.Id("last_name");
        public By address = By.Id("address1");
        public By country = By.Id("country");
        public By state = By.Id("state");
        public By city = By.Id("city");
        public By zipcode = By.Id("zipcode");
        public By mobile = By.Id("mobile_number");
        public By createAcc = By.XPath("//button[@data-qa='create-account']");
        public By form = By.XPath("//form[@action]");


        

        public SignupPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver,TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(signupPage));
        }

            
    }
}
