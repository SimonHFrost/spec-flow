﻿Feature: Adding 1 to numbers
	My won't you help me
	Sharp wind does confuse me so
	What number comes next?

@goodButton
Scenario: Click the good button (Specflow)
	Given I have entered 0 into the textbox
	When I press the good button
	Then the result should be 1

@goodButton
Scenario: Click the good button multiple times (Specflow)
	Given I have entered 0 into the textbox
	When I press the good button 10 times
	Then the result should be 10

@faultyButton
Scenario: Click the faulty button (Specflow)
	Given I have entered 0 into the textbox
	When I press the faulty button
	Then the result should be 1
