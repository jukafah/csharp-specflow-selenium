using OpenQA.Selenium;
using SpecFlow.Selenium.Pages;
using TechTalk.SpecFlow;

namespace SpecFlow.Selenium.Features.StepDefinitions
{
	[Binding]
	public class CommonSteps
	{
		private readonly IWebDriver driver;
	    private readonly CommonPage page;

		public CommonSteps(IWebDriver driver)
		{
			this.driver = driver;
		    this.page = new CommonPage(this.driver);
		}

		[Given(@"I am on ""(.*)""")]
		public void GivenIAmOn(string destinationUrl)
		{
			page.GoTo(destinationUrl);
		}

		[Then(@"I am presented with the ""(.*)"" homepage")]
		public void ThenIAmPresentedWithTheHomepage(string expectedUrl)
		{
		    page.CheckUrl(expectedUrl);
		}
	}
}
