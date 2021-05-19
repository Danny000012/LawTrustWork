using OpenQA.Selenium;
using ScriptingToFramework.Models;
using NUnit.Framework;
using System;

namespace ScriptingToFramework.Pages
{
    public class SignUpPage
    {
        public readonly SignUpPageMap Map;

        public SignUpPage(IWebDriver driver)
        {
            Map = new SignUpPageMap(driver);
        }

        public void ClickSignUpLink(SignUpModel data)
        {
            var loginHeader = Map.LoginHeader.Text;
            Assert.AreEqual("LOGIN", loginHeader);
            Map.SignUp.Click();
            var header = Map.SignUpHeader.Text;
            Assert.AreEqual("REGISTER YOUR ACCOUNT DETAILS", header);
            Map.Name.SendKeys(data.Name);
            ErrorHandling(data);
            Map.PhoneNumber.SendKeys(data.PhoneNumber);
            Map.JobTitle.SendKeys(data.JobTitle);
            Map.CompanyName.SendKeys(data.CompanyName);
            Map.TCCheckBox.Click();
            Map.BtnNext.Click();
        }

        public void SignUpCreateProfile(SignUpModel data)
        {
            var loginHeader = Map.LoginHeader.Text;
            Assert.AreEqual("LOGIN", loginHeader);
            Map.SignUp.Click();
            var header = Map.SignUpHeader.Text;
            Assert.AreEqual("REGISTER YOUR ACCOUNT DETAILS", header);
            Map.Name.SendKeys(data.Name);
            Map.Email.SendKeys(data.Email);
            Map.PhoneNumber.SendKeys(data.PhoneNumber);
            Map.JobTitle.SendKeys(data.JobTitle);
            Map.CompanyName.SendKeys(data.CompanyName);
            Map.TCCheckBox.Click();
            Map.BtnNext.Click();
        }

        public void ErrorHandling(SignUpModel data)
        {
            try 
            {
                var k = "This email address already exists";
                Map.Email.SendKeys(data.Email);
                if (Map.EmailErrorMsg.Text == k)
                {
                    Assert.AreEqual(Map.EmailErrorMsg.Text, k);
                }
            } 
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public class SignUpPageMap
    {
        IWebDriver _driver;

        public SignUpPageMap(IWebDriver driver)
        {
            _driver = driver;
        }
        
        public IWebElement LoginHeader => _driver.FindElement(By.XPath("//h1[text()='LOGIN']"));
        public IWebElement SignUp => _driver.FindElement(By.XPath("//a[text()='Sign Up']"));
        public IWebElement SignUpHeader => _driver.FindElement(By.XPath("//h1[text()='REGISTER YOUR ACCOUNT DETAILS']"));
        public IWebElement Name => _driver.FindElement(By.XPath("//input[@id='userName']"));
        public IWebElement Email => _driver.FindElement(By.XPath("//input[@id='email1']"));
        public IWebElement PhoneNumber => _driver.FindElement(By.XPath("//input[@id='mobile']"));
        public IWebElement JobTitle => _driver.FindElement(By.XPath("//input[@id='job']"));
        public IWebElement CompanyName => _driver.FindElement(By.XPath("//input[@id='company']"));
        public IWebElement TCCheckBox => _driver.FindElement(By.XPath("//div[@class='checkbox checkbox-success']"));
        public IWebElement BtnNext => _driver.FindElement(By.XPath("//button[@type='submit']"));
        public IWebElement EmailErrorMsg => _driver.FindElement(By.XPath("//p[text()='This email address already exists']"));

    }
}