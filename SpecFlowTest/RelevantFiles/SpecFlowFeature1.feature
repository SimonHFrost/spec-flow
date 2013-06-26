Feature: Adding 1 to numbers

Scenario: Click the good button
	Given I have entered 0 into the textbox
	When I press the good button
	Then the result should be 1 on the screen

Scenario: Click the good button multiple times
	Given I have entered 0 into the textbox
	When I press the good button 10 times
	Then the result should be 10 on the screen

Scenario: Clicking the broken button
	Given I have entered 0 into the textbox
	When I press the broken button
	Then the result should be 1 on the screen
