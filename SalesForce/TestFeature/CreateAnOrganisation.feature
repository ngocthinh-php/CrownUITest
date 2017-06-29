@Organisation
Feature: 05 - Create_An_Organisation_
	In order to manage customer and supplier data
	As a CCS entity
	I want to have a mechanism to input organisation data

Background: User Navigates to Create Organisation Page
    Given I am on Select New Organisation Record Type page

@RegressionTest
Scenario Outline: 01 User Creates a new Supplier Organisation
	When I Select Organisation Record Type as <organisation>
	And Click on Continue button
	Then I should be presented with organisation Edit Page
	When I enter mandatory information for supplier <organisationName>, <sector>, <organisationType>
	And click on Save button
	Then a new organisation <organisationName> would be created
Examples: 
	| organisation | organisationName | sector             | organisationType       |
	| Supplier     | Supplier001      | Central Government | Health                 |
	| Supplier     | Supplier002      | Local Government   | County Council         |
	| Supplier     | Supplier003      | Police             | Police Authority       |
	| Supplier     | Supplier004      | Private            | Private Sector Enabler |
	| Supplier     | Supplier005      | Utility            | Energy                 |
	| Supplier     | Supplier006      | Health             | GP Practice            |

Scenario Outline: 02 User creates Customer organisation
	When I Select Organisation Record Type as <organisation>
	And Click on Continue button
	Then I should be presented with organisation Edit Page
	When I enter mandatory information for customer <organisationName>, <sector>, <organisationType>, <status>
	And click on Save button
	Then a new organisation <organisationName> would be created
Examples: 
	| organisation | organisationName | sector             | organisationType             | status |
	| Organisation | Customer001      | Central Government | Health			              | Active |
	| Organisation | Customer002      | Education          | Colleges of Higher Education | Active |
	| Organisation | Customer003      | Local Government   | County Council               | Active |
	| Organisation | Customer004      | Police             | Police Authority             | Active |
	| Organisation | Customer005      | Private            | Private Sector Enabler       | Active |

