using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace Test3
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(AppManager manager) : base(manager)
        {
        }

        public void ClickOnLoginButton()
        {
            driver.FindElement(By.CssSelector("input:nth-child(6)")).Click();
        }

        public void EnterPassword(AccauntData user)
        {
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys(user.Password);
        }

        public void EnterEmail(AccauntData user)
        {
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys(user.Login);
        }

        public void ClickOnLogoutButton()
        {
            driver.FindElement(By.CssSelector(".button-primary")).Click();
        }

        public string GetHead1LoginPage()
        {
            return driver.FindElement(By.CssSelector("h1:nth-child(2)")).Text;
        }
    }
}
