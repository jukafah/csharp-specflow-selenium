Feature: Lorem Ipsum
		As a User,
		I can generate variations of Lorem Ipsum text
	
# Using tables to create class objects
Scenario: Paragraphs - Generate with starting text
	Given I am on the homepage
	When I generate text with default starting text
	| Amount | Text Generation Type | Start With Default Text |
	| 5      | Paras           		| True                    |
	Then the paragraphs are generated correctly
	
Scenario: Paragraphs - Generate without starting text
	Given I am on the homepage
	When I generate text without default starting text
	| Amount | Text Generation Type | Start With Default Text |
	| 5      | Paras           		| False                   |
	Then the paragraphs are generated correctly

Scenario: Words - Generate with starting text
	Given I am on the homepage
	When I generate text with default starting text
		| Amount | Text Generation Type | Start With Default Text |
		| 5      | Words           		| True                    |
	Then the words are generated correctly

Scenario: Words - Generate without starting text
	Given I am on the homepage
	When I generate text without default starting text
		| Amount | Text Generation Type | Start With Default Text |
		| 5      | Words           		| False                   |
	Then the words are generated correctly

# Scenario Outlines for testing boundaries
Scenario Outline: Bytes - Generating less than 28 bytes of text is exact match with default text
	Given I am on the homepage
	When I generate <amount> bytes of text with default starting text
	Then <expectedAmount> bytes of text generates and "Lorem ipsum dolor sit amet." exact match is <value>
	
Scenarios:
	| amount	| expectedAmount 	| value	|
	| 0 		| 27				| true  |
	| 14  		| 27  				| true	|
	| 27    	| 27     			| true	|
	| 28     	| 28				| false	|
	
Scenario: Lists - Generate single list with starting text
	Given I am on the homepage
	When I generate "1" list with default starting text
	Then the list generates correctly
	
Scenario: Lists - Generate single list without starting text
	Given I am on the homepage
	When I generate "1" list without default starting text
	Then the list generates correctly

Scenario: Lists - Generate multiple lists with starting text
	Given I am on the homepage
	When I generate "8" lists with default starting text
	Then the list generates correctly

Scenario: Lists - Generate multiple lists without starting text
	Given I am on the homepage
	When I generate "8" lists without default starting text
	Then the list generates correctly
	
Scenario: DocString - This is a Doc String
	Given I am on the homepage
	When I generate text
	Then I am presented with
	"""
	Stuff is generated
	"""