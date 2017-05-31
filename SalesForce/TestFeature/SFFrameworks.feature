Feature: Framework Management
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@RegressionTest
Scenario: Create and Publish a Framework
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

	Scenario: Forecast a Framework
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Search a Framework
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

	Scenario: Delete or disable a Framework
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen