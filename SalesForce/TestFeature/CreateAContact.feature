@Contacts
Feature: 06 - Create_a_Contact_
	As a CCS staff I would 
	I would like to create contact details
	So that the contact details can be associated for various operations

Background: User Navigates to Create Organisation Page
    Given I am on Contact Page
@RegressionTest
Scenario Outline: Create a contact with all fields populated
	When I enter new contact details <firstName>, <lastName>, <jobTitle>, <department>, <contactType>, <mktgCampaignRef>, <status>, <telephone>, <extension>, <mobile>, <email>, <addnlemail>, <orgName>, <country>, <addressLine>, <townCity>, <county>, <postcode> and save the record
	Then contact record should be created successfully
Examples: 
| firstName | lastName | jobTitle        | department | contactType     | mktgCampaignRef | status | telephone   | extension | mobile      | email                          | addnlemail                     | orgName     | country | addressLine    | townCity | county | postcode |
| Test001   | Customer | Help Desk Agent | CSC        | General Contact | 0001            | Active | 01225895988 | 0102      | 07941373315 | Test001Customer@mailinator.com | Test001Customer@mailinator.com | Customer001 | England | 1 Queen Street | Bristol  | Avon   | BS158BA  |
| Test002   | Customer | Help Desk Agent | CSC        | General Contact | 0001            | Active | 01225895988 | 0102      | 07941373315 | Test002Customer@mailinator.com | Test002Customer@mailinator.com | Customer002 | England | 2 Queen Street | Bristol  | Avon   | BS158BA  |
| Test001   | Supplier | Help Desk Agent | CSC        | General Contact | 0001            | Active | 01225895988 | 0102      | 07941373315 | Test001Supplier@mailinator.com | Test001Supplier@mailinator.com | Supplier001 | England | 1 Queen Street | Bristol  | Avon   | BS158BA  |
| Test002   | Supplier | Help Desk Agent | CSC        | General Contact | 0001            | Active | 01225895988 | 0102      | 07941373315 | Test002Supplier@mailinator.com | Test002Supplier@mailinator.com | Supplier001 | England | 2 Queen Street | Bristol  | Avon   | BS158BA  |


