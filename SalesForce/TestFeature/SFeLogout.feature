Feature: Salesforce Logout
	In order to come out of my profile
	As a CCS portal user  
	I should be given an option to click

@RegressionTest
Scenario: User Logs out of the Salesforce
	Given I am on Salesforce page
	When I click on log out option 
	Then I should be logged out of the Salesforce application