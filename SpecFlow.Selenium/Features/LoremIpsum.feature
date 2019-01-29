Feature: Lorem Ipsum
		As a User,
		I can generate variations of Lorem Ipsum text
	
#Scenario: Generated text counts amount of generated text
#	Given I am on the homepage
#	When I generate text
#	Then the calculated amount of generated text displays
	
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
	
	
#Scenario: Paragraphs - Generate without starting text
#	Given I am on the homepage
#	When I generate <1> paragraph without starting text
#	Then the correct amount of paragraphs are generated
#	
#Scenario: Paragraphs - Generate with starting text v2
#	Given I am on the homepage
#	When I generate text
#	  |Count	|Type		|Starting Text	|
#	  |10     	|Paragraph	|True       	|
#	Then the generated text matches
#	
#Scenario Outline: Generate text with
#	Given I am on the homepage
#	When I generate paragraphs with <amount> and <start_text>
#	Then the paragraph generates with <amount> and <start_text>
#	
#Scenarios:
#	|amount | start_text |
#	| 1     | true       |
#	| 5     | false      |
#	
#Scenario: Words - Generates correct amount with "Start with 'Lorem ipsum dolor sit amet...'" selected
#	
#Scenario: Words - Generates correct amount without "Start with 'Lorem ipsum dolor sit amet...'" selected
#	
#Scenario: Bytes - Generates correct amount with "Start with 'Lorem ipsum dolor sit amet...'" selected
#	
#Scenario: Bytes - Generates correct amount without "Start with 'Lorem ipsum dolor sit amet...'" selected
#	
#Scenario: Lists - Generates correct amount with "Start with 'Lorem ipsum dolor sit amet...'" selected
#	
#Scenario: Lists - Generates correct amount without "Start with 'Lorem ipsum dolor sit amet...'" selected
	