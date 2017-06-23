@Cases
Feature: Create TC Case
	In order to manage enquiries and other requirements 
	As a Helpdesk Agent or an employee in other parts of CCS entity
	I would like to be given a mechanism to create cases

Background: 
	Given C on Cases page
@RegressionTest

Scenario: 02 Create C Tech Support Case
	When C click on New button
	Then C should be navigated to Case type Selection page
	When C select case Type as 'Tech Support' and continue
	Then C should be presented with Case Edit screen
	When C populate mandatory Tech Support Case information 'Customer005', 'Technology Support', 'caseOrigin', 'Test001 Contact', 'Triage', 'Incident', 'Open', 'Green', 'eMarketplace', 'User Accounts', 'New User', 'Tech Support Case with Email', 'Tech Support Case with Email' for the case and Save the record
	Then C Case record be created successfully 

Scenario Outline: 03 Create C Tech Support Case again
	When C click on New button
	Then C should be navigated to Case type Selection page
	When C select case Type as <caseType> and continue
	Then C should be presented with Case Edit screen
	When C populate mandatory Tech Support Case information as <orgName>,<technologyTeam>, <caseOrigin>, <contactName>, <workflow>, <category>, <status>, <priority>, <supportClassification>, <SCLevel1>, <SCLevel2>, <subject>, <description> for the case and Save the record
	Then C Case record be created successfully 
Examples: 
| caseType     | caseOrigin | contactName     | technologyTeam     | orgName     | workflow | category | status | priority | supportClassification | SCLevel1      | SCLevel2 | subject                      | description                  |
| Tech Support | Phone      | Test001 Contact | Technology Support | Customer001 | Triage   | Incident | Open   | Green    | eMarketplace          | User Accounts | New User | Tech Support Case with Email | Tech Support Case with Email |