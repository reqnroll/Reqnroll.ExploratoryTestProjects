@dynamicignore
Feature: DynamicIgnore

@ignore
Scenario: Ignored scenario
	When I do something

Scenario Outline: Outline with ignored examples
	Given the first parameter is "<param>"
	And <other param> is the second parameter
	When I do something
	Then the scenario <result>
Examples:
	| param   | other param | result |
	| foo bar | 12          | passes |
@ignore
Examples: Ignored tests
	| param | other param | result |
	| hello | 12          | passes |

Scenario: Dynamically ignored
	Given the scenario is ignored
	When I do something

Scenario: Dynamically marked inconclusive
	Given the scenario is marked inconclusive
	When I do something

Scenario: Pending scenario
	Given the scenario is pending
	When I do something
