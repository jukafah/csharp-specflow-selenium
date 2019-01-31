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
        
        [Then(@"the words are generated correctly")]
        public void ThenTheWordsAreGeneratedCorrectly()
        {
            _page.AssertWordsGeneration(_testData.LoremIpsum);
        }
        
        [When(@"I generate (.*) bytes of text with default starting text")]
        public void WhenIGenerateBytesOfTextWithDefaultStartingText(int amount)
        {
            _page.GenerateAsBytesWithStartText(amount);
        }
        
        [Then(@"(.*) bytes of text generates and ""(.*)"" exact match is (.*)")]
        public void ThenBytesOfTextGeneratesAndExactMatchIsTrue(int amount, string startText, bool exactMatch)
        {
            _page.AssertBytesGeneration(amount, startText, exactMatch);
        }
        
        // can combine gherkin to run same step in effort to be more readable
        [When(@"I generate ""(.*)"" list without default starting text")]
        [When(@"I generate ""(.*)"" lists without default starting text")]
        public void WhenIGenerateListWithoutDefaultStartingText(int amount)
        {
            // different usage of keeping test data
            _page.GenerateListWithoutStartText(_testData, amount);
        }    
        
        // can combine gherkin to run same step in effort to be more readable
        [When(@"I generate ""(.*)"" list with default starting text")]
        [When(@"I generate ""(.*)"" lists with default starting text")]
        public void WhenIGenerateListsWithDefaultStartingText(int amount)
        {
            _page.GenerateListWithStartText(_testData, amount);
        }
        
        [Then(@"the list generates correctly")]
        public void ThenTheListGeneratesCorrectly()
        {
            _page.AssertListsGeneration(_testData);
        }       
    }
}