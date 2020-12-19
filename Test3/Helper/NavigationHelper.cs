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
    public class NavigationHelper : HelperBase
    {
        public NavigationHelper(AppManager manager) : base(manager)
        {
        }

        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl("https://app.simplenote.com/");
        }

        public void OpenMenu()
        {
            driver.FindElement(By.CssSelector(".search-bar > span:nth-child(1) > .icon-button")).Click();
        }

        public void OpenAllNotes()
        {
            driver.FindElement(By.CssSelector(".navigation-bar-item:nth-child(0) > .button")).Click();
        }

        public void OpenSettings()
        {
            driver.FindElement(By.CssSelector(".navigation-bar-item:nth-child(1) > .button")).Click();
        }
        public void OpenTrash()
        {
            driver.FindElement(By.CssSelector(".navigation-bar-item:nth-child(2) > .button")).Click();
        }

        public void CloseSettings()
        {
            driver.FindElement(By.CssSelector(".dialog-title-side > .button")).Click();
        }

        public string getAccountLogin()
        {
            return driver.FindElement(By.CssSelector(".settings-account-name")).Text;
        }
    }
}
