using AutomationExcerciseframework.Helpers;
using AutomationExcerciseframework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AutomationExcerciseframework.Steps
{
    [Binding]
    public class ContactUsSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HeaderPage hp = new HeaderPage(Driver);

        [Given(@"user opent contact us page")]
        public void GivenUserOpentContactUsPage()
        {
            ut.ClickOnElement(hp.contactLink);
        }
        
        [When(@"user enters all required fields")]
        public void WhenUserEntersAllRequiredFields()
        {
            ContactUsPage cup = new ContactUsPage(Driver);
            ut.EnterTextInElement(cup.name, TestConstants.FirstName + " " + TestConstants.LastName);
            ut.EnterTextInElement(cup.email, TestConstants.Username);
            ut.EnterTextInElement(cup.subject, TestConstants.Subject);
            ut.EnterTextInElement(cup.message, TestConstants.Message);

        } 
        
        [When(@"user submits contacts us form")]
        public void WhenUserSubmitsContactsUsForm()
        {
            ContactUsPage cup = new ContactUsPage(Driver);
            Driver.FindElement(cup.form).Submit();
                
        }
        
        [When(@"confirms the promp message")]
        public void WhenConfirmsThePrompMessage()
        {
            IAlert alert = Driver.SwitchTo().Alert();
            alert.Accept();
        }
        
        [Then(@"user will receive '(.*)' message")]
        public void ThenUserWillReceiveMessage(string successMessage)
        {
            Assert.True(ut.TextPresentinElement(successMessage), "User message was not sent successfully via contact form");
        }
    }
}
