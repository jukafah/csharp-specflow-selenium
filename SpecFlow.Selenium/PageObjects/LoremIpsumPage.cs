using FluentAssertions;
using OpenQA.Selenium;
using SpecFlow.Selenium.Models;

namespace SpecFlow.Selenium.PageObjects
{
    public class LoremIpsumPage : PageObject
    {
        private readonly IWebDriver _driver;
        private string _url = "https://www.lipsum.com/";

        public LoremIpsumPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void Navigate()
        {
            base.Navigate(_url);
        }

        // separate asserts for different expectations
        public void AssertWordsGeneration(LoremIpsum loremIpsum)
        {
            var generatedText = GeneratedLoremIpsum.Text;
            var generatedTextStartsWithDefault = generatedText.StartsWith(loremIpsum.DefaultText);
            var generatedWords = generatedText.Split().Length.ToString();
            
            generatedWords.Should().Be(loremIpsum.Amount);
            generatedTextStartsWithDefault.Should().Be(loremIpsum.StartWithDefaultText);
        }

        // separate asserts for different expectations
        public void AssertParagraphsGeneration(LoremIpsum loremIpsum)
        {
            var generatedText = GeneratedLoremIpsum.Text;
            var generatedTextStartsWithDefault = generatedText.StartsWith(loremIpsum.DefaultText);
            var generatedParagraphs = GeneratedLoremIpsum.FindElements(By.CssSelector("p")).Count.ToString();

            generatedParagraphs.Should().Be(loremIpsum.Amount);
            generatedTextStartsWithDefault.Should().Be(loremIpsum.StartWithDefaultText);
        }

        // separate asserts for different expectations
        public void AssertBytesGeneration(LoremIpsum loremIpsum)
        {
            
        }

        // separate asserts for different expectations
        public void AssertListsGeneration(LoremIpsum loremIpsum)
        {
            
        }

        // Separate steps to select / generate with or without, error on the side of no conditionals in test code
        public void GenerateWithStartingText(LoremIpsum loremIpsum)
        {
            Amount.Clear();
            Amount.SendKeys(loremIpsum.Amount);
            GenerationType(loremIpsum.TextGenerationType.ToString().ToLowerInvariant()).Click();
            GenerateLoremIpsum.Click();
        }
        
        // Separate steps to select / generate with or without, error on the side of no conditionals in test code
        public void GenerateWithoutStartingText(LoremIpsum loremIpsum)
        {
            Amount.Clear();
            Amount.SendKeys(loremIpsum.Amount);
            GenerationType(loremIpsum.TextGenerationType.ToString().ToLowerInvariant()).Click();
            StartingText.Click();
            GenerateLoremIpsum.Click();
        }

        private IWebElement Amount => _driver.FindElement(By.CssSelector("[name='amount']"));
        
        // Using one selector to get different types based on enum in model
        private IWebElement GenerationType(string type) => _driver.FindElement(By.CssSelector($"#{type}"));

        private IWebElement GenerateLoremIpsum => _driver.FindElement(By.CssSelector("#generate"));
        
        private IWebElement GeneratedLoremIpsum => _driver.FindElement(By.CssSelector("#lipsum"));

        private IWebElement StartingText => _driver.FindElement(By.CssSelector("#start"));

    }
}