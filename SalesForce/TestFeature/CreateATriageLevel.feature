@Triage
Feature: 04 - Create_A_Triage_Level_
	As a CCS Salesforce system user
	I would like to create Triage Levels data
	So that I can use the data later for other related activities

Background: 
	Given I am on Triage Level Edit page

@RegressionTest
Scenario Outline: Create Triage Level Data
	When I populate the field values <triageLevel>, <slaDays> , <isDefault>
	And Save the rcord	
	Then the new <triageLevel> record should be created successfully
Examples: 
	| triageLevel   | slaDays | isDefault |
	| Test Level 01 | 0.25    | Yes       |
	| Test Level 02 | 0.5     | No        |
	| Test Level 03 | 1.0     | No        |