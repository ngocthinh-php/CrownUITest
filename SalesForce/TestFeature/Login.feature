Feature: 01 - Login to Salesforce
	In order to access necessary information on Salesforce 
	As a CCS employee
	I want to be able to log in to the application

@RegressionTest
Scenario Outline: 1 Failed Login to the Salesforce
	Given I have navigated to Salesforce login page
	When I enter user details <email>, <password>
	And I click on Login button 
	Then I should see Error Message <errormessage>
Examples: 
| email                                    | password | errormessage                                                                                               |
| chitta.jena@crowncommercial.gov.uk.bauqa |          | Please enter your password.                                                                                |
| chitta.jena@crowncommercial.gov.uk.bauqa | Data1111 | Please check your username and password. If you still can't log in, contact your Salesforce administrator. |

Scenario Outline: 2 Successful User Login to the Salesforce
	Given I have navigated to Salesforce login page
	When I enter user details <email>, <password>
	And I click on Login button 
	Then I should be navigated to landingpage
Examples: 
| email                                    | password  | 
| chitta.jena@crowncommercial.gov.uk.bauqa | Data@3456 | 