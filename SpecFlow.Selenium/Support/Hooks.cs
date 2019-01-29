using System;
using BoDi;
using System.IO;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.Extensions;
using SpecFlow.Selenium.Factories;
using SpecFlow.Selenium.Models;

namespace SpecFlow.Selenium.Support
{
	[Binding]
	public class Hooks
	{
		private readonly IObjectContainer _objectContainer;
		private IWebDriver _driver;
		private static TestData _testData;
		private static DriverFactory _driverFactory;

		public Hooks(IObjectContainer objectContainer)
		{
			_objectContainer = objectContainer;
		}

		// @TODO: DriverFactory for multi browser parallel execution
		[BeforeTestRun]
		public static void BeforeTestRun()
		{
			_testData = new TestData();
			_driverFactory = new DriverFactory();
			Directory.CreateDirectory(Path.Combine("..", "..", "TestResults"));
		}

		[BeforeScenario(Order = 0)]
		public void BeforeScenario()
		{
			_driver = _driverFactory.CreateDriver();
			_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
			_driver.Manage().Window.Maximize();
			_objectContainer.RegisterInstanceAs(_driver);
			_objectContainer.RegisterInstanceAs(_testData);
		}

//		[BeforeScenario(Order = 1)]
//		public void ScenarioSetup()
//		{
//			// code that needs to execute after beforeScenario
//		}

//		[BeforeScenario("web")]
//		public void BeforeWebScenario()
//		{
//			// code that executes before scenarios tagged with `@web`
//		}
		
//		[BeforeScenario("web")]
//		public static void BeforeAutomatedScenario(ScenarioContext scenarioContext)
//		{
//			if (scenarioContext.ScenarioInfo.Tags.Contains("automated"))
//			{
//				// code that executes for scenarios tagge as `web` and `automated`
//			}
//		}

		[AfterScenario]
		public void AfterScenario(ScenarioContext scenarioContext)
		{
			if (scenarioContext.TestError != null)
			{
				_driver.TakeScreenshot().SaveAsFile(Path.Combine("..", "..", "TestResults", $"{scenarioContext.ScenarioInfo.Title}.png"), ScreenshotImageFormat.Png);
			}
            _driver?.Dispose();
		}

//	    [AfterTestRun]
//	    public static void AfterTestRun()
//	    {
//	        // code that runs after the test run
//	    }
	}
}
