Feature: 04 - Create a Contact
	As a CCS staff I would 
	I would like to create contact details
	So that the contact details can be associated for various operations

Background: User Navigates to Create Organisation Page
    Given I am on Contact Page
	When I click on New button
	Then I should be directed to Contact Edit Page
@RegressionTest
Scenario Outline: Create a contact with all fields populated
	When I enter new contact details
	And click on Save button
	Then contact record should be created successfully
Examples: 
| salutation | firstName | lastName | jobTitle        | department | ccsEmailYN | contactType     | reportsTo | mktgCampaignRef | status | telephone   | extension | mobile      | email                         | addnlemail                    | usrResearchPartYN | orgName     | country | addressLine    | townCity | County | postcode | origin | notes  |
| Mr.        | Test012   | Contact  | Help Desk Agent | CSC        | N          | General Contact |           | 0001            | Active | 01225895988 | 0102      | 07941373315 | Test012Contact@mailinator.com | Test010Contact@mailinator.com | N                 | Customer005 | England | 9 Queen Street | Bristol  | Avon   | BS158BA  |        | A Test |
| Mr.        | Test013   | Contact  | Help Desk Agent | CSC        | N          | General Contact |           | 0001            | Active | 01225895988 | 0101      | 07941373315 |                               | Test010Contact@mailinator.com | Y                 | Customer005 | England | 7 Queen Street | Bristol  | Avon   | BS158BA  |        | A Test |
| Mr.        | Test014   | Contact  |                 |            | N          |                 |           |                 | Active | 01225895988 | 0105      |             |                               |                               | N                 | Customer005 |         |                |          |        |          |        |        |


