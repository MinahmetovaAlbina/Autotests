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
    public class NoteHelper : HelperBase
    {
        public NoteHelper(AppManager manager) : base(manager)
        {
        }

        public void WriteNote(string text)
        {
            driver.FindElement(By.CssSelector(".inputarea")).SendKeys(text);
        }

        public void CreateNote()
        {
            driver.FindElement(By.CssSelector("span:nth-child(3) > .icon-button")).Click();
        }

        public void DeleteNote()
        {
            driver.FindElement(By.CssSelector(".note-toolbar__button:nth-child(3) .icon-button")).Click();
        }

        public string GetNoteTitle()
        {
            return driver.FindElement(By.CssSelector(".note-title")).Text;
        }

        public string Getfff()
        {
            return driver.FindElement(By.CssSelector(".mtk1")).Text;
        }
    }
}
