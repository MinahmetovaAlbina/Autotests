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
    public class AppManager
    {
        public IWebDriver Driver { get => driver; }
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;

        public NavigationHelper Navigate { get; }
        public LoginHelper Auth { get; }
        public NoteHelper Note { get; }

        private static ThreadLocal<AppManager> app = new ThreadLocal<AppManager>();

        public static AppManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                AppManager newInstance = new AppManager();
                newInstance.Navigate.OpenHomePage();
                app.Value = newInstance;
            }
            return app.Value;
        }

        private AppManager()
        {
            driver = new FirefoxDriver();
            //driver.Manage().Window.Maximize();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
            Navigate = new NavigationHelper(this);
            Auth = new LoginHelper(this);
            Note = new NoteHelper(this);
        }

        ~AppManager()
        {
            try
            {
                driver.Close();
                driver.Quit();
            }
            catch (Exception)
            {
                //ignore
            }
        }
    }
}
