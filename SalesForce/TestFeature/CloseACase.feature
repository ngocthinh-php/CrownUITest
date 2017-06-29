Feature: 09 - Close_A_Case_
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I am on Cases page
@RegressionTest
Scenario Outline: 01 Close an Enquiry Cases
	When I click on New button
	Then I should be navigated to Case type Selection page
	When I select case Type as <caseType> and continue
	Then I should be presented with Case Edit screen
	When I populate mandatory Enquiry case information <orgName>, <contactName>, <team>, <status>, <priority>, <triageLevel>, <caseOrigin>, <caseSubject>, <description> for the case and Save the record
	Then a Case record be created successfully 
Examples: 
| caseType | orgName     | contactName      | team     | status | priority | triageLevel | caseOrigin | caseSubject  | description          |
| Enquiry  | Supplier001 | Test001 Supplier | --None-- | Open   | Green    | Level 1     | Email      | Enquiry Case | Enquiry Case Test001 |

Scenario Outline: 02 Close a Tech Support Case 
	When I click on New button
	Then I should be navigated to Case type Selection page
	When I select case Type as <caseType> and continue
	Then I should be presented with Case Edit screen
	When I populate mandatory Tech Support Case information <contactName>, <orgName>, <technologyTeam>, <caseOrigin>, <workflow>, <category>, <status>, <priority>, <supportClassification>, <subject>, <description> for the case and Save the record
	Then a Case record be created successfully 
Examples: 
| caseType     | contactName      | orgName     | technologyTeam                | caseOrigin | workflow | category | status | priority | supportClassification | subject                  | description                  |
| Tech Support | Test001 Customer | Customer001 | Technology Support            | Email      | Triage   | Problem  | Open   | Green    | SPAM                  | AutoTest Tech Support001 | Tech Support Case with Email |

Scenario Outline: 03 Close a Procurement Case 
	When I click on New button
	Then I should be navigated to Case type Selection page
	When I select case Type as <caseType> and continue
	Then I should be presented with Case Edit screen
	When I populate mandatory Tech Support Case information <contactName>, <orgName>, <technologyTeam>, <caseOrigin>, <workflow>, <category>, <status>, <priority>, <supportClassification>, <subject>, <description> for the case and Save the record
	Then a Case record be created successfully 
Examples: 
| caseType     | contactName      | orgName     | technologyTeam                | caseOrigin | workflow | category | status | priority | supportClassification | subject                  | description                  |
| Procurement | Test001 Customer | Customer001 | Technology Support            | Email      | Triage   | Problem  | Open   | Green    | SPAM                  | AutoTest Tech Support001 | Tech Support Case with Email |
| Procurement | Test002 Customer | Customer002 | Applications & Infrastructure | Phone      | Triage   | Request  | Open   | Green    | SalesForce            | AutoTest Tech Support002 | Tech Support Case with Email |

