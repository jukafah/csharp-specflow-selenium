using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlow.Selenium.Pages
{
	public class SearchPage
	{
		private readonly IWebDriver driver;

		public SearchPage(IWebDriver driver)
		{
			this.driver = driver;
			PageFactory.InitElements(this.driver, this);
		}

		public void PerformSearch(string searchText)
		{
			searchBox.Clear();
			searchBox.SendKeys(searchText);
			searchBox.Submit();
		}

		public void SelectResult(string expResult)
		{
			IWebElement link = FindResult(expResult);
			Assert.IsNotNull(link, $"Could not find link for: {expResult}");
			link.Click();
		}

		private IWebElement FindResult(string expResult)
		{
			foreach (IWebElement link in searchResults)
			{
				if (link.Text.ToUpper().Contains(expResult.ToUpper())) {
					return link;
				}
			}
			return null;
		}

	    // ---- Decorated selectors ---- //
	    [FindsBy(How = How.CssSelector, Using = "#lst-ib")]
	    private IWebElement searchBox;

	    [FindsBy(How = How.CssSelector, Using = "#ires .g .r a")]
	    private IList<IWebElement> searchResults;
	}
}
