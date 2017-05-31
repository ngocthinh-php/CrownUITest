Feature: Reset Password 
	In order to access my account or profile 
	As a buyer
	I want to be reminded of my password to log in to the account

@RegressionTest
Scenario Outline: Buyer resets password
	Given Buyer is in portal login page
	When clicks on forgot your password link
	Then Reset your password page should get loaded
	When Buyer enters <email> 
	When clicks on send password reset email button 
    Then user should be navigated to email confirmation page
Examples:
| email                |
| atest@mailinator.com |