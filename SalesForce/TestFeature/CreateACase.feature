@Cases
Feature: 07 - Create_a_Case_
	In order to manage enquiries and other requirements 
	As a Helpdesk Agent or an employee in other parts of CCS entity
	I would like to be given a mechanism to create cases

Background: 
	Given I am on Cases page
@RegressionTest

Scenario Outline: 01 Create Enquiry Case (CCS Admin User)
	When I click on New button
	Then I should be navigated to Case type Selection page
	When I select case Type as <caseType> and continue
	Then I should be presented with Case Edit screen
	When I populate mandatory Enquiry case information <orgName>, <contactName>, <team>, <status>, <priority>, <triageLevel>, <caseOrigin>, <caseSubject>, <description> for the case and Save the record
	Then a Case record be created successfully 
Examples: 
| caseType | orgName     | contactName      | team     | status | priority | triageLevel | caseOrigin | caseSubject  | description          |
| Enquiry  | Supplier001 | Test001 Supplier | --None-- | Open   | Green    | Level 1     | Email      | Enquiry Case | Enquiry Case Test001 |


Scenario Outline: 02 Create Tech Support Case (CCS Admin User)
	When I click on New button
	Then I should be navigated to Case type Selection page
	When I select case Type as <caseType> and continue
	Then I should be presented with Case Edit screen
	When I populate mandatory Tech Support Case information <contactName>, <orgName>, <technologyTeam>, <caseOrigin>, <workflow>, <category>, <status>, <priority>, <supportClassification>, <subject>, <description> for the case and Save the record
	Then a Case record be created successfully 
Examples: 
| caseType     | contactName      | orgName     | technologyTeam                | caseOrigin | workflow | category | status | priority | supportClassification | subject                  | description                  |
| Tech Support | Test001 Customer | Customer001 | Technology Support            | Email      | Triage   | Problem  | Open   | Green    | SPAM                  | AutoTest Tech Support001 | Tech Support Case with Email |
| Tech Support | Test002 Customer | Customer002 | Applications & Infrastructure | Phone      | Triage   | Request  | Open   | Green    | SalesForce            | AutoTest Tech Support002 | Tech Support Case with Email |

Scenario Outline: 03 Create a Procurement Case (CCS Admin User)
	When I click on New button
	Then I should be navigated to Case type Selection page
	When I select case Type as <caseType> and continue
	Then I should be presented with Case Edit screen
	When I populate mandatory Procurement Case information <orgName>, <procReference>, <status>, <value>, <straImpToCustomer>, <sourComplexity>, <ccsTeam>, <CASCategory>, <caseOrigin>, <subject>, <description>, <coErgAppReqlist>, <dwpCARList>, <olncAppReqList>, <modrcaAppReqList>, <dwpmcatAppReqList>, <priority> for the case and Save the record
	Then a Case record be created successfully 
Examples: 
| caseType    | orgName     | procReference | status      | value       | straImpToCustomer | sourComplexity | ccsTeam     | CASCategory    | caseOrigin | subject              | description          | coErgAppReqlist | dwpCARList | olncAppReqList | modrcaAppReqList | dwpmcatAppReqList | priority |
| Procurement | Customer001 | Test0001      | In Progress | Below £100k | Important         | Basic          | Buying Team | Test Marketing | Email      | Test Procurement 001 | Test Procurement 001 | No              | No         | Yes            | No               | No                | Green    |
| Procurement | Customer002 | Test0002      | In Progress | Below £100k | Important         | Complex        | Buying Team | Test Marketing | Email      | Test Procurement 002 | Test Procurement 001 | No              | No         | Yes            | No               | No                | Green    |









