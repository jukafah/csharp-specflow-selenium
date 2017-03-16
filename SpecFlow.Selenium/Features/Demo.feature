Feature: Demo
		As a User,
		Google searching should work on all platforms

@C001 @smokeTest @regression
Scenario: Google Search - appium
	Given I am on "http://www.google.com"
	When I search for "appium"
	And select "Appium" in the search results
	Then I am presented with the "http://appium.io/" homepage

@C002 @regression
Scenario: Google Search - specflow
	Given I am on "http://www.google.com"
	When I search for "specflow"
	And select "SpecFlow" in the search results
	Then I am presented with the "http://specflow.org/" homepage

@C003 @smokeTest @regression
Scenario: Google Search - selenium
	Given I am on "http://www.google.com"
	When I search for "selenium"
	And select "Selenium - Web Browser Automation" in the search results
	Then I am presented with the "http://www.seleniumhq.org/" homepage

@C004 @regression
Scenario: Google Search - xamarin
	Given I am on "http://www.google.com"
	When I search for "xamarin"
	And select "Xamarin" in the search results
	Then I am presented with the "https://www.xamarin.com/" homepage