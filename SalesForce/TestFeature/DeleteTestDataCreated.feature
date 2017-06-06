Feature: 08 - Delete Test Data Created
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@RegressionTest
Scenario Outline: Delete Contact Data
	Given I am in Contact Screen
	When I click the Delete button on <contactId>
	Then the contact record should be deleted successfully
Examples: 
| contactId     |
| CONT-00095734 |
| CONT-00095735 |

Scenario Outline: Delete Case Data
	Given I am in Case Screen
	When I click the Delete button on <caseNumber>
	Then the case record should be deleted successfully
Examples: 
| caseNumber |
| 00067950   |
| 00067951   |

Scenario Outline: Delete Account Data
	Given I am in organisation Screen
	When I click the Delete button on <organisationName>
	Then the organisation record should be deleted successfully
Examples: 
| organisationName |
| ABCL             |
| Test001          |
| Test002          |



