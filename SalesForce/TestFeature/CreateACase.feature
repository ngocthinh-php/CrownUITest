@Cases
Feature: 05 - Create a Case
	In order to manage enquiries and other requirements 
	As a Helpdesk Agent or an employee in other parts of CCS entity
	I would like to be given a mechanism to create cases

Background: 
	Given I am on Cases page
@RegressionTest

Scenario Outline: Create Enquiry Case
	When I click on New button
	Then I should be navigated to Case type Selection page
	When I select case Type as <caseType>
	And Click on Continue button
	Then I should be presented with Case Edit screen
	When I populate mandatory information <orgName>, <contactName>, <team>, <status>, <priority>, <triageLevel>, <caseOrigin>, <subject>, <description> for the case and Save the record
	Then a Case record be created successfully 
Examples: 
| caseType | orgName     | contactName     | team     | status | priority | triageLevel | caseOrigin | subject      | description          |
| Enquiry  | Customer004 | Test004 Contact | --None-- | Open   | Green    | Level 1     | Email      | Enquiry Case | Enquiry Case Test001 |
