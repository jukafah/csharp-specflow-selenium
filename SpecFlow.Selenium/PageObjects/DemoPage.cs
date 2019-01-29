using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Xunit;

namespace SpecFlow.Selenium.PageObjects
{
    public class DemoPage : PageObject
    {
        private readonly IWebDriver _driver;

        public DemoPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void SearchFor(string searchText)
        {
            SearchBox.Clear();
            SearchBox.SendKeys(searchText);
            SearchBox.Submit();
        }

        public void SelectResult(string expResult)
        {
            SearchResults
                .First(element => element.Text.Contains(expResult))
                .Click();
        }


        public IWebElement SearchBox => _driver.FindElement(By.CssSelector("[name='q']"));

        public IList<IWebElement> SearchResults => _driver.FindElements(By.CssSelector("#ires .g .r a"));
    }
}