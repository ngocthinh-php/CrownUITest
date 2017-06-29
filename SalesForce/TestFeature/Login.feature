Feature: 01_A - Login_to_Salesforce_
	In order to access necessary information on Salesforce 
	As a CCS employee
	I want to be able to log in to the application

@RegressionTest
Scenario Outline: 1 Failed Login to the Salesforce
	Given I have navigated to Salesforce login page
	When I enter user details <email>, <password>
	And I click on Login button 
	Then I should see Error MessagePlease enter your password.
Examples: 
| email                                    | password |
| chitta.jena@crowncommercial.gov.uk.bauqa |          |

Scenario Outline: 2 Failed Login to the Salesforce
	Given I have navigated to Salesforce login page
	When I enter user details <email>, <password>
	And I click on Login button 
	Then I should see Error MessagePlease check your username and password. If you still can't log in, contact your Salesforce administrator.
Examples: 
| email                                    | password |                                                                                              
| chitta.jena@crowncommercial.gov.uk.bauqa | Data1111 | 

Scenario Outline: 3 Successful User Login to the Salesforce
	Given I have navigated to Salesforce login page
	When I enter user details <email>, <password>
	And I click on Login button 
	Then I should be navigated to landingpage
Examples: 
| email                                    | password  | 
| chitta.jena@crowncommercial.gov.uk.bauqa | Data@3456 | 