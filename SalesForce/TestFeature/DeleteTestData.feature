@Delete
Feature: 24 - Delete Test Data Created
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: User is logged in	
    Given user is in landing page
@RegressionTest
Scenario Outline: 01 Delete Case Data
	Given I am on the Mass Delete Cases Page
	When I filter based on <contactName> and <accountName> 
	And I press Delete button
	Then all the related case records are deleted	
Examples: 
| contactName | accountName |
| Contact     | Customer    |
| Contact     | Supplier    |
Scenario Outline: 02 Delete Contact Data
	Given I am on the Mass Delete Contact Page
	When I filter based on <lastName> and <firstName>
	And I press Delete button
	Then all the related contact records are deleted	
Examples: 
| lastName | firstName |
| Contact  | Test      |

Scenario Outline: 03 Delete Organisation Data
	Given I am on the Mass Delete Accounts Page
	When I filter based on <organisationName>
	And I press Delete button
	Then all the related Organisation records are deleted	
Examples: 
| organisationName|
| Supplier |
| Customer |

