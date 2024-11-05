Feature: Calculator

Run tests with 
	dotnet test --logger "console;verbosity=detailed"
to see retries.

@retry
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be around 120

@retry
Scenario Outline: Multiply two numbers
    Given the first number is 5
    And the second number is 7
    When the two numbers are multiplied
    Then the result should be around 35
Examples: 
	| a | b | result |
	| 5 | 7 | 35     |
	| 2 | 3 | 6      |