using OpenQA.Selenium;
using SpecFlow.Selenium.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlow.Selenium.StepDefinitions
{
	[Binding]
	public class StepDefinitions
	{
		private readonly DemoPage _page;
		
		public StepDefinitions(IWebDriver driver)
		{
			_page = new DemoPage(driver);
		}
		
		[Given(@"I am on ""(.*)""")]
		public void GivenIAmOn(string url)
		{
			_page.Navigate(url);
		}
		
		// demonstrates running the same steps but for scenarios with different tags
		[Given(@"I am on ""(.*)"""), Scope(Tag = "web")]
		public void GivenOn(string url)
		{
			_page.Navigate(url);
		}
        
		[When(@"I search for ""(.*)""")]
		public void WhenISearchFor(string library)
		{
			_page.SearchFor(library);
		}
        
		[When(@"select ""(.*)"" in the search results")]
		public void WhenSelectInTheSearchResults(string library)
		{
			_page.SelectResult(library);
		}
        
		[Then(@"I am presented with the ""(.*)"" homepage")]
		public void ThenIAmPresentedWithTheHomepage(string library)
		{
			_page.AssertTitle(library);
		}
	}
}