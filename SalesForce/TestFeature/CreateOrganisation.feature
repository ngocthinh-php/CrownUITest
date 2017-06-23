@Organisation
Feature: 03 Create Organisation
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
	When I enter mandatory information for supplier <organisationName>, <sector>, <organisationType>, <dunsNumber>, <indirectSME>
	And click on Save button
	Then a new organisation <organisationName> would be created
	Examples: 
	| organisation | organisationName | sector             | organisationType       | dunsNumber | indirectSME |
	| Supplier     | Supplier001      | Central Government | Health                 | 456789012  | 0.5         |
	| Supplier     | Supplier002      | Local Government   | County Council         | 345678901  | 1.2         |
	| Supplier     | Supplier003      | Police             | Police Authority       | 234567890  | 1.0         |
	| Supplier     | Supplier004      | Private            | Private Sector Enabler | 123456789  | 1.5         |
	| Supplier     | Supplier005      | Utility            | Energy                 | 012345678  | 0.00        |
	| Supplier     | Supplier006      | Health             | GP Practice            | 567890123  | 5           |
	
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

