@Cases
Feature: RecentCases
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: User Navigates to Cases Page
    Given I am on Cases page
@RegressionTest
Scenario Outline: Retrieve Recent Cases Data
	When I go to Recent Cases section
	Then I should be able to retrieve all the table data
	And can click on <caseSubject>
Examples: 
| caseSubject |
| Test Q      |