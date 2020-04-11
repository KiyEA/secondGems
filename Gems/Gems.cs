using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Gems
{
    public class Gems : IDisposable
    {
        private readonly IWebDriver Browser;
        public Gems()
        {
            Browser = new ChromeDriver();
        }
        bool GetElement(By locator)
        {
            List<IWebElement> elements = Browser.FindElements(locator).ToList();

            if (elements.Count > 0) return true;
            else return false;
        }
        public bool IsExist(string value)
        {
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("https://gemsdev.ru/geometa/");
            bool Link = GetElement(By.XPath($"//*[text()='{value}']"));
            return Link;
        }
        public bool IsSiteExist(string value)
        {
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("https://gemsdev.ru/geometa/");
            bool Link = GetElement(By.XPath($"//a[contains(@href, '{value}')]"));
            return Link;
        }

        public void Dispose()
        {
            Browser.Quit();
        }
    }
}
