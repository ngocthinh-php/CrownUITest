@Survey
#related to [US2524, US2536]
Feature: 09 - Survey Feedback Object 
	In order to allow the users to input their Survey comments
	As a CCS business team
	I want to have a mechanism to allow users to input a text with a length in line with Clicktool

Background: User is in SetUp Page
    Given I am in SetUp page
@RegressionTest
Scenario Outline: User loads validates Survey Feedback Object
	When I search for "Survey Feedback Object" in quick search box
	Then I should see the "Survey Feedback Object"
	When I load the "Survey Feedback Object"
	Then I should be able to validate the <fieldName> , its associated <apiName> and <dataType>
	Examples: 
	| fieldName      | apiName     | dataType             |
	| Improve        | Improve__c  | Long Text Area(2000) |
	| Did Well       | Did_Well__c | Long Text Area(2000) |
	| Relational NPS | RNPS__c     | Number(2, 0)         |
