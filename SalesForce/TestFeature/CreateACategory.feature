@Cases
Feature: 11 - Create a Category
	In order to manage enquiries and other requirements 
	As a Helpdesk Agent or an employee in other parts of CCS entity
	I would like to be given a mechanism to create cases

Background: 
	Given I am on Category page
@RegressionTest

Scenario Outline: 01 Create Category data
	When I click on New Category button
	Then I should be navigated to Category Edit page
	When I enter category details <catName>, <catCode>, <catType>, <parent>, <catExtId>, <parentName>, <pgDescription> and Save the record
	Then a Category record is created successfully 
Examples: 
	| catName                     | catCode | catType             | parent              | codeType | catExtId | parentName          | pgDescription      |
	| Test Communications         |         | CAS Master Category |                     | CPV      | 15       |                     |                    |
	| Test Marketing              | MA      | CAS Category        | Test Communications |          | 1512     | Test Communications |                    |
	| Test Marketing Services     |         | CAS Sub Category    | Test Marketing      |          | 1512373  | Test Marketing      | A Test to sort out |
	| Test Marketing Spl Services |         | CAS Sub Category    | Test Marketing      |          | 1512375  | Test Marketing      | A Test to sort out |
	

