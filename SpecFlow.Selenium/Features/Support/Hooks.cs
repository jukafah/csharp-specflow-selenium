using System;
using BoDi;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace SpecFlow.Selenium.Features.Support
{
	[Binding]
	public class Hooks
	{
		private readonly IObjectContainer objectContainer;
		private IWebDriver driver;
		static DesiredCapabilities desiredCapabilities;

		public Hooks(IObjectContainer objectContainer)
		{
			this.objectContainer = objectContainer;
		}

		[BeforeTestRun]
		public static void BeforeTestRun()
		{
		    // Switch to reading caps form Devices.json
			Dictionary<string, object> caps = new Dictionary<string, object>();
			caps.Add("browserName", "chrome");

			desiredCapabilities = new DesiredCapabilities(caps);
		}

		[BeforeScenario]
		public void BeforeScenario()
		{
			driver = new RemoteWebDriver(desiredCapabilities);

			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

			objectContainer.RegisterInstanceAs(driver);
		}


		[AfterScenario]
		public void AfterScenario()
		{
			if (driver != null)
			{
				driver.Dispose();
			}
		}


	    [AfterTestRun]
	    public static void AfterTestRun()
	    {
	        // code that runs after the test run
	    }
	}
}
