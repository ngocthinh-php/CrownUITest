@Navigation
Feature: 02 - User Navigation
	In order to access different parts of the application
	As a CCS Employee
	I should be given option to navigate

Background: User is logged in
	Given I am on Salesforce Landing Page

@RegressionTest

Scenario: 01 User Navigates to Profile Home Page (through tab) 	
	When I click on the home tab
	Then I should see the home page

Scenario: 02 User Navigates to Catter Page (through tab)	
	When I click on the Chatter tab
	Then I should see the Chatter page

Scenario: 28 User Navigates to Organisations Page (through tab)	
	When I click on the Organisations tab
	Then I should see the Organisations page

Scenario: 04 User Navigates to Contacts Page (through tab)	
	When I click on the Contacts tab
	Then I should see the Contacts page

Scenario: 05 User Navigates to Cases Page (through tab)	
	When I click on the Cases tab
	Then I should see the Cases page

Scenario: 06 User Navigates to Contracts Page (through tab)	
	When I click on the Contracts tab
	Then I should see the Contracts page

Scenario: 07 User Navigates to Frameworks Page (through tab)	
	When I click on the Frameworks tab
	Then I should see the Frameworks page

Scenario: 08 User Navigates to Reports Page (through tab)	
	When I click on the Reports tab
	Then I should see the Reports page

Scenario: 09 User Navigates to Knowledge Page (through tab)	
	When I click on the Knowledge tab
	Then I should see the Knowledge page

Scenario: 10 User Navigates to Triage Levels Page (through tab)	
	When I click on the Triage Levels tab
	Then I should see the Triage Levels page

Scenario: 11 User opens All tabs option
	When I click on the All tabs tab
	Then I should see the All tabs page

Scenario: 12 User Navigates to Profile Home Page (through navigation link) 	
	When I click on the home link
	Then I should see the home page

Scenario: 13 User Navigates to Catter Page (through navigation link)	
	When I click on the Chatter link
	Then I should see the Chatter page

Scenario: 14 User Navigates to Organisations Page (through navigation link)	
	When I click on the Organisations link
	Then I should see the Organisations page

Scenario: 15 User Navigates to Contacts Page (through navigation link)	
	When I click on the Contacts link
	Then I should see the Contacts page

Scenario: 16 User Navigates to Cases Page (through navigation link)	
	When I click on the Cases link
	Then I should see the Cases page

Scenario: 17 User Navigates to Contracts Page (through navigation link)	
	When I click on the Contracts link
	Then I should see the Contracts page

Scenario: 18 User Navigates to Frameworks Page (through navigation link)	
	When I click on the Frameworks link
	Then I should see the Frameworks page

Scenario: 19 User Navigates to Reports Page (through navigation link)	
	When I click on the Reports link
	Then I should see the Reports page

Scenario: 20 User Navigates to Knowledge Page (through navigation link)	
	When I click on the Knowledge link
	Then I should see the Knowledge page

Scenario: 21 User Navigates to Triage Levels Page (through navigation link)	
	When I click on the Triage Levels link
	Then I should see the Triage Levels page

Scenario: 22 User navigates to Helpdesk Agent Profile page
	When I click on the Helpdesk agent profile 
	Then I should see Helpdesk Agent Profile page

Scenario: 23 User navigates to CCS Business Intelligence Profile page
	When I click on the CCS Business Intelligence Profile 
	Then I should see CCS Business Intelligence Profile page

Scenario: 24 User navigates to CCS CRM User profile page
	When I click on the CCS CRM User profile 
	Then I should see CCS CRM User profile page

Scenario: 25 User navigates to CCS Framework Users profile page
	When I click on the CCS Framework Users profile 
	Then I should see CCS Framework Users profile page

Scenario: 26 User navigates to CCS Procurement & Contract User profile page
	When I click on the CCS Procurement & Contract User profile
	Then I should see CCS Procurement & Contract User profile page

