@Chatter
Feature: 08 - Create_a_Chatter_Post_
	In order to be part of the community
	As a CCS system user
	I should be able to see the posts, raise questions, cases

Background: 
	Given I am on Chatter Page
@RegressionTest
#Question Details field in the following scenario cannot be identified hence skipped for now to be investigated
Scenario Outline: Raise a Question
	When I enter a chatter question with <questionTitle>
	#When I enter a chatter question with <questionTitle> and <questionDetails>
	And click on Ask button
	Then I can verify the question under <showUpdates>
Examples: 
| questionTitle              | questionDetails         | showUpdates |
| Chatter Automation Test001 | Chatter Automation Test | Questions   |