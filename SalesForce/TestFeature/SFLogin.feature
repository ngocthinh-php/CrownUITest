Feature: Login to Salesforce
	In order to access necessary information on Salesforce 
	As a CCS employee
	I want to be able to log in to the application

@RegressionTest
Scenario Outline: CCS Employee Logs in to the Salesforce
	Given I have navigated to Salesforce login page
	When I enter user details with <email> and <password>
	And I click on Remember Me check box
	And I click on Login button 
	Then I should be logged in successfully
Examples:
| email                                    | password  |
| chitta.jena@crowncommercial.gov.uk.pemqa | Data@2345 |