Feature: Portal Registeration process
	In order to access ccs purchasing platform information and supplier details
	As an user / customer
	I want to be given option to register

@RegressionTest

Scenario Outline: Successful Customer registeration
	Given I am on portal login page
	When I click on Register link
	Then I should be navigated to the self register page
	When I select the option Public Sector
	And I enter my details <firstname> and <lastname> and <email>
	And I click on TnC checkbox 
	And I click on Sign Up button
	Then I should be presented with next part of self registration page
	When I enter contactnumber as <contactnumber>
	And select organisation as <organisation>
	And click on new SignUp button
	Then I should see registration confirmation page
Examples:
| firstname | lastname | email                     | contactnumber | organisation |
| CCS       | Test     | ccstest005@mailinator.com | 01225895988   | Mailinator   |

Scenario Outline: Customer registeration failure - email address already registered
	Given I am on portal login page
	When I click on Register link
	Then I should be navigated to the self register page
	When I select the option Public Sector
	And I enter my details <firstname> and <lastname> and <email>
	And I click on TnC checkbox 
	And I click on Sign Up button
	Then I should be presented with a message saying email address registered

Examples:
| firstname | lastname | email                     | contactnumber | organisation |
| CCS       | Test     | ccstest001@mailinator.com | 01225895988   | Mailinator   |

Scenario Outline: Successful Customer registeration - organisation not in the list
	Given I am on portal login page
	When I click on Register link
	Then I should be navigated to the self register page
	When I select the option Public Sector
	And I enter my details <firstname> and <lastname> and <email>
	And I click on TnC checkbox 
	And I click on Sign Up button
	Then I should be presented with next part of self registration page
	When I enter contactnumber as <contactnumber>
	And select organisation as <organisation>
	Then a new text box appears 
	When I enter new organisation details as <newOrganisation>
	And click on another SignUp button
	Then I should see registration confirmation page
Examples:
| firstname | lastname | email                        | contactnumber | organisation | newOrganisation |
| CCS       | Test     | ccstestoth002@mailinator.com | 01225896788   | Other        | CRInfosystems   |

Scenario: Private Sector User Registration
	Given I am on portal login page
	When I click on Register link
	Then I should be navigated to the self register page
	When I select the option Private Sector
	Then I should be presented with a new page that says to use SID4GOV to Register