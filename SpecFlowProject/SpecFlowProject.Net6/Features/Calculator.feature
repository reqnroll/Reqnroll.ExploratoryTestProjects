﻿#language: en
Feature: Calculator

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120
	And external step definitions 4 Reqnroll work

@mytag
Scenario: Add two numbers differently
	Given the numbers are 50,70
	When the two numbers are added
	Then the result should be 120