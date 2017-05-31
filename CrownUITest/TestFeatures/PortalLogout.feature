Feature: Portal Logout
	In order to come out of my profile
	As a CCS portal user  
	I should be given an option to click

@RegressionTest
Scenario: User Logs out of the portal
	Given I am on portal page
	When I click on log out option from the profile menu
	Then I should be logged out of the profile
