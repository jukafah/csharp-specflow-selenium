using OpenQA.Selenium;
using SpecFlow.Selenium.Pages;
using TechTalk.SpecFlow;

namespace SpecFlow.Selenium.Features.StepDefinitions
{
	[Binding]
	public class SearchSteps
	{
		private readonly IWebDriver driver;
		private readonly SearchPage page;

		public SearchSteps(IWebDriver driver)
		{
			this.driver = driver;
			this.page = new SearchPage(this.driver);
		}

		[When(@"I search for ""(.*)""")]
		public void WhenISearchFor(string searchText)
		{
			page.PerformSearch(searchText);
		}

		[When(@"select ""(.*)"" in the search results")]
		public void WhenSelectInTheSearchResults(string expectedLink)
		{
			page.SelectResult(expectedLink);
		}
	}
}
