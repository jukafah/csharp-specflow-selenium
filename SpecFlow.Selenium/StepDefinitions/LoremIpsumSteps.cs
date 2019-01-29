using System;
using OpenQA.Selenium;
using SpecFlow.Selenium.Models;
using SpecFlow.Selenium.PageObjects;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlow.Selenium.StepDefinitions
{
    [Binding]
    public class LoremIpsumSteps
    {
        private readonly LoremIpsumPage _page;
        private readonly TestData _testData;

        public LoremIpsumSteps(IWebDriver driver, TestData testData)
        {
            _page = new LoremIpsumPage(driver);
            _testData = testData;
        }
        
        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            _page.Navigate();
        }
        
        // Transform tables into class objects
        [When(@"I generate text with default starting text")]
        public void WhenIGenerateTextWithDefaultStartingText(Table table)
        {
            _testData.LoremIpsum = table.CreateInstance<LoremIpsum>();
            _page.GenerateWithStartingText(_testData.LoremIpsum);
        }
        
        [When(@"I generate text without default starting text")]
        public void WhenIGenerateTextWithoutDefaultStartingText(Table table)
        {
            _testData.LoremIpsum = table.CreateInstance<LoremIpsum>();
            _page.GenerateWithoutStartingText(_testData.LoremIpsum);
        }
        
        [Then(@"the paragraphs are generated correctly")]
        public void ThenTheParagraphsAreGeneratedCorrectly()
        {
            _page.AssertParagraphsGeneration(_testData.LoremIpsum);
        }
    }
}