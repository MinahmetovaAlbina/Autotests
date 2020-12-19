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
    public class HelperBase
    {
        protected AppManager manager;
        protected IWebDriver driver;

        public HelperBase(AppManager manager)
        {
            this.manager = manager;
            driver = manager.Driver;
        }
    }
}
