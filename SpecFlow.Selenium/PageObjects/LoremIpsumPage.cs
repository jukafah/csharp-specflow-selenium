using System;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlow.Selenium.Models;
using SpecFlow.Selenium.Utility;

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

        // separate asserts for different expectations, both using LoremIpsum model
        public void AssertWordsGeneration(LoremIpsum loremIpsum)
        {
            var generatedText = GeneratedLoremIpsum.Text;
            var generatedTextStartsWithDefault = generatedText.StartsWith(loremIpsum.DefaultText);
            var generatedWords = generatedText.Split().Length.ToString();
            
            generatedWords.Should().Be(loremIpsum.Amount);
            generatedTextStartsWithDefault.Should().Be(loremIpsum.StartWithDefaultText);
        }

        // separate asserts for different expectations, both using LoremIpsum model
        public void AssertParagraphsGeneration(LoremIpsum loremIpsum)
        {
            var generatedText = GeneratedLoremIpsum.Text;
            var generatedTextStartsWithDefault = generatedText.StartsWith(loremIpsum.DefaultText);
            var generatedParagraphs = GeneratedLoremIpsum.FindElements(By.CssSelector("p")).Count.ToString();

            generatedParagraphs.Should().Be(loremIpsum.Amount);
            generatedTextStartsWithDefault.Should().Be(loremIpsum.StartWithDefaultText);
        }

        // different type of assert, not using model
        public void AssertBytesGeneration(int amount, string defaultText, bool exactMatch)
        {
            var generatedText = GeneratedLoremIpsum.Text;
            var generatedTextBytesInString = generatedText.Length;
            var generatedTextStartText = generatedText.StartsWith(defaultText);

            generatedTextBytesInString.Should().Be(amount);
            generatedTextStartText.Should().Be(exactMatch);
        }

        // separate asserts for different expectations
        public void AssertListsGeneration(TestData testData)
        {
            var generatedText = GeneratedLoremIpsum.Text;
            var generatedTextStartsWithDefault = generatedText.StartsWith(testData.LoremIpsum.DefaultText);
            var generatedLists = GeneratedLoremIpsum.FindElements(By.CssSelector("ul")).Count.ToString();

            generatedLists.Should().Be(testData.LoremIpsum.Amount);
            generatedTextStartsWithDefault.Should().Be(testData.LoremIpsum.StartWithDefaultText);
        }

        public void GenerateAsBytesWithStartText(int amount)
        {
            Amount.Clear();
            Amount.SendKeys(amount.ToString());
            Bytes.Click();
            GenerateLoremIpsum.Click();
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
        
        // defining models from data passed through from step instead
        public void GenerateListWithStartText(TestData testData, int amount)
        {
            testData.LoremIpsum = new LoremIpsum
            {
                Amount = amount.ToString(),
                StartWithDefaultText = true,
                TextGenerationType = TextGenerationType.Lists
            };
            

            Amount.Clear();
            Amount.SendKeys(testData.LoremIpsum.Amount);
            GenerationType(testData.LoremIpsum.TextGenerationType.ToString().ToLowerInvariant()).Click();
            GenerateLoremIpsum.Click();
        }

        // defining models from data passed through from step instead
        public void GenerateListWithoutStartText(TestData testData, int amount)
        {
            testData.LoremIpsum = new LoremIpsum
            {
                Amount = amount.ToString(),
                StartWithDefaultText = false,
                TextGenerationType = TextGenerationType.Lists
            };
            
            Amount.Clear();
            Amount.SendKeys(testData.LoremIpsum.Amount);
            GenerationType(testData.LoremIpsum.TextGenerationType.ToString().ToLowerInvariant()).Click();
            StartingText.Click();
            GenerateLoremIpsum.Click();
        }

        private IWebElement Amount => _driver.FindElement(By.CssSelector("[name='amount']"));
        
        // Using one selector to get different types based on enum in model
        private IWebElement GenerationType(string type) => _driver.FindElement(By.CssSelector($"#{type}"));

        private IWebElement Bytes => _driver.FindElement(By.CssSelector("#bytes"));

        private IWebElement GenerateLoremIpsum => _driver.FindElement(By.CssSelector("#generate"));
        
        private IWebElement GeneratedLoremIpsum => _driver.FindElement(By.CssSelector("#lipsum"));

        private IWebElement StartingText => _driver.FindElement(By.CssSelector("#start"));
    }
}