Feature: 09 - User Logs out of Salesforce
	In order to come out of my profile
	As a CCS portal user  
	I should be given an option to click

@RegressionTest
Scenario: User Logs out of the Salesforce
	Given I am Logged in to Salesforce
	When I click on logout option
	Then I should be logged out of the Salesforce application