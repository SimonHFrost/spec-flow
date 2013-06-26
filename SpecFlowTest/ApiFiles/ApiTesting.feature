Feature: ApiTesting
	It's too tedious
	To check when the frost settles
	Much like regressions

@scenarioTest
Scenario: Bale Arms Customer Import
	Given I am logged in as customer 'bale arms'
	And I have 70 of my customers ready to import
	When I import these customers
	Then I want to see them displayed in Route
