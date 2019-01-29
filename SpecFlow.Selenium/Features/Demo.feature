Feature: Demo
		As a User,
		I can find information about libraries this demo uses

@C001 @smokeTest
Scenario: Google Search - FluentAssertions
	Given I am on "http://www.google.com"
	When I search for "Fluent Assertions"
	And select "Fluent Assertions - Fluent Assertions" in the search results
	Then I am presented with the "Fluent Assertions - Fluent Assertions" homepage

@C002 @regression
Scenario: Google Search - SpecFlow
	Given I am on "http://www.google.com"
	When I search for "SpecFlow"
	And select "SpecFlow" in the search results
	Then I am presented with the "SpecFlow - Binding Business Requirements to .NET Code" homepage

@C003 @smokeTest
Scenario: Google Search - Selenium
	Given I am on "http://www.google.com"
	When I search for "Selenium"
	And select "Selenium - Web Browser Automation" in the search results
	Then I am presented with the "Selenium - Web Browser Automation" homepage

@C004 @regression
Scenario: Google Search - JetBrains Rider
	Given I am on "http://www.google.com"
	When I search for "JetBrains Rider"
	And select "Rider: The Cross-Platform .NET IDE from JetBrains" in the search results
	Then I am presented with the "Rider: The Cross-Platform .NET IDE from JetBrains" homepage