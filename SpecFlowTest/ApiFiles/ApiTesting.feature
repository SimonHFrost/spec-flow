Feature: ApiTesting
	It's too tedious
	To check when the frost settles
	Much like regressions

@scenarioTest
Scenario: Bay Alarms Customer Import
	Given I am logged in as customer 'Bay Alarms'
	And I have 70 of my customers ready to import
	When I import these customers
	Then I want to verify that they exist
