Feature: Manage Cases
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@RegressionTest
Scenario: Create an Enquiry Case
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

	Scenario: Create a Procurement Case
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

	Scenario: Create a Technical Support Case
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

	Scenario: Create an Application & Infrastructure Case
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

