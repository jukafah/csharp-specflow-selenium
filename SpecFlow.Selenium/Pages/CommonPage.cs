using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlow.Selenium.Pages
{
    public class CommonPage
    {
        private readonly IWebDriver driver;

        public CommonPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void GoTo(string destinationUrl)
        {
            driver.Navigate().GoToUrl(destinationUrl);
        }

        public void CheckUrl(string expectedUrl)
        {
            string actualUrl = driver.Url;
            Assert.AreEqual(expectedUrl, actualUrl);
        }

    }
}