Feature: 03 - Create a New Account
	In order to manage customer and supplier data
	As a CCS entity
	I want to have a mechanism to input organisation data


@RegressionTest
Scenario: 01 User Navigates to Create Organisation Page
	Given I am on Organisation Home Page
	When I click on New button
	Then I should be directed to Select New Organisation Record Type page
Scenario Outline: 02 User Creates a new Supplier Organisation
	When I Select Organisation Record Type as <organisation>
	And Click on Continue button
	Then I should be presented with organisation Edit Page
	When I enter mandatory information for supplier <organisationName>, <sector>, <organisationType>
	And click on Save button
	Then a new organisation <organisationName> would be created
	Examples: 
	| organisation | organisationName | sector           | organisationType |
	| Supplier     | Supplier001      | Public Sector    | Health           |
@ignore
Scenario Outline: 03 User creates Customer organisation
	When I Select Organisation Record Type as <organisation>
	And Click on Continue button
	Then I should be presented with organisation Edit Page
	When I enter mandatory information for customer <organisationName>, <sector>, <organisationType>, <status>
	And click on Save button
	Then a new organisation <organisationName> would be created
	Examples: 
	| organisation | organisationName | sector           | organisationType | status |
	| Organisation | Customer001      | Local Government | County Council   | Active |
