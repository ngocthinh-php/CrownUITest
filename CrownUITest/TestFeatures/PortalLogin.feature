Feature: Portal Log in tests
	In order to access necessary information on purchasing platform 
	As a CCS portal user
	I want to be able to log in to the portal

@RegressionTest
Scenario Outline: Buyer Logs in to the portal
	Given User has navigated to portal login page
	When User enters user details with <email> and <password> 
	And User clicks on Login button 
    Then User should be logged in successfully
Examples:
| email					| password  |
| ismith@mailinator.com	| Data@1234 |

Scenario Outline: Buyer fails to log in to the portal
	Given User has navigated to portal login page
	When User enters user details with <email> and <password> 
	And User clicks on Login button 
    Then User should be presented with login failure message
Examples:
| email					| password		|
| ismith@mailinator.com	| Password123	|

Scenario Outline: CCS Employee Logs in to the portal
	Given User has navigated to portal login page
	When User enters user details with <email> and <password>
	And User clicks on Login button 
    Then User should be logged in successfully
Examples:
| email                                    | password  |
| chitta.jena@crowncommercial.gov.uk.pemqa | Data@3456 |

Scenario Outline: CCS Employee fails to log in to the portal
	Given User has navigated to portal login page
	When User enters user details with <email> and <password> 
	And User clicks on Login button  
	Then User should be presented with login failure message
Examples:
| email                                    | password    |
| chitta.jena@crowncommercial.gov.uk.pemqa | Password123 |