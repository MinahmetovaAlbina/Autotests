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
    public class TestBase
    {
        protected AppManager app;

        [SetUp]
        public void SetUp()
        {
            app = AppManager.GetInstance();
        }
    }
}
