Feature: Create a New Account
	In order to manage customer and supplier data
	As a CCS entity
	I want to have a mechanism to input organisation data

@RegressionTest
Scenario Outline: User Creates a new Customer Organisation
	Given I am on Organisation Home Page
	When I click on New button
	Then I should be directed to Select New Organisation Record Type page
	When I Select Organisation Record Type as <organisation>
	And Click on Continue button
	Then I should be presented with organisation Edit Page
	When I enter mandatory information <organisationName> and select <sector> and select <status>
	Then I Should be presented with organisation type drop down
	When I select a value from <organisationType> drop down field
	And click on Save button
	Then a new organisation would be created
Examples:
|organisation	|organisationName	|sector				|status|organisationType|
|Organisation	|Customer001		|Local Government	|Active|County Council	|
	 
Scenario Outline: User Creates a new Supplier Organisation
	Given I am on Organisation Home Page
	When I click on New button
	Then I should be directed to Select New Organisation Record Type page
	When I Select Organisation Record Type as <organisation>
	And Click on Continue button
	Then I should be presented with organisation Edit Page
	When I enter mandatory information <organisationName> and select <sector>
	Then I Should be presented with organisation type drop down
	When I select a value from <organisationType> drop down field
	And click on Save button
	Then a new organisation would be created
Examples:
|organisation	|organisationName	|sector				|organisationType	|
|Customer		|Supplier001		|Public Sector		|Health				|
	