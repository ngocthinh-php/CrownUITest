Feature: 05 - Create a Case
	In order to manage enquiries and other requirements 
	As a Helpdesk Agent or an employee in other parts of CCS entity
	I would like to be given a mechanism to create cases

@RegressionTest
Scenario: 01.0.0 - Go to Case Type Selection Page
	Given I am on Case screen
	When I click on New button
	Then I should be navigated to Case type Selection page
Scenario: 02.1.0 - Go to Case Edit 
	When I select case Type as <caseType>
	And Click on Continue button
	Then I should be presented with "Case Edit" screen

Scenario: 02.1.1 - Create an Enquiry Case
	When I populate mandatory information for the case and Save the record
	Then an Case be created successfully 

Scenario: 02.1.2 - Create a Procurement Case
	When I populate mandatory information for the case and Save the record
	Then an Case be created successfully 

Scenario: 02.1.3 - Create a Technical Support Case
	When I populate mandatory information for the case and Save the record
	Then an Case be created successfully 

Scenario: 02.1.4 - Create an Application & Infrastructure Case
	When I populate mandatory information for the case and Save the record
	Then an Case be created successfully 

