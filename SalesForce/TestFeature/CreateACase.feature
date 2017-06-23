@Cases
Feature: 05 - Create a Case
	In order to manage enquiries and other requirements 
	As a Helpdesk Agent or an employee in other parts of CCS entity
	I would like to be given a mechanism to create cases

Background: 
	Given I am on Cases page
@RegressionTest

Scenario Outline: 01 Create Enquiry Case
	When I click on New button
	Then I should be navigated to Case type Selection page
	When I select case Type as <caseType> and continue
	Then I should be presented with Case Edit screen
	When I populate mandatory Enquiry case information <orgName>, <contactName>, <team>, <status>, <priority>, <triageLevel>, <caseOrigin>, <caseSubject>, <description> for the case and Save the record
	Then a Case record be created successfully 
Examples: 
| caseType | orgName     | contactName     | team     | status | priority | triageLevel | caseOrigin | caseSubject  | description          |
| Enquiry  | Customer001 | Test001 Contact | --None-- | Open   | Green    | Level 1     | Email      | Enquiry Case | Enquiry Case Test001 |


Scenario Outline: 02 Create Tech Support Case
	When I click on New button
	Then I should be navigated to Case type Selection page
	When I select case Type as <caseType> and continue
	Then I should be presented with Case Edit screen
	When I populate mandatory Tech Support Case information <orgName>, <contactName>, <technologyTeam>, <caseOrigin>, <workflow>, <category>, <status>, <priority>, <supportClassification>, <SCLevel1>, <SCLevel2>, <subject>, <description> for the case and Save the record
	Then a Case record be created successfully 
Examples: 
| caseType     | orgName     | contactName     |technologyTeam                | caseOrigin | workflow  | category | status | priority | supportClassification | SCLevel1      | SCLevel2 | subject                      | description                  |
| Tech Support | Customer001 | Test001 Contact |Technology Support            | Phone      | Triage    | Incident | Open   | Green    | eMarketplace          | User Accounts | New User | Tech Support Case with Email | Tech Support Case with Email | 
| Tech Support | Customer001 | Test001 Contact |Applications & Infrastructure | Email      | Escalated | Incident | Open   | Green    | eMarketplace          | User Accounts | New User | Tech Support Case with Email | Tech Support Case with Email | 




