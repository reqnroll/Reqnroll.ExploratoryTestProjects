Feature: Basics

This is the description of the **"basics" feature**.

* It includes scenarios to show *basic examples* for formatters.
* This description is displayed as [Markdown](https://en.wikipedia.org/wiki/Markdown) in the formatter output.

@basic
Scenario: Passing scenario
	Given the first parameter is "foo bar"
	And 42 is the second parameter
	When I do something
	Then the scenario passes

Scenario: Failing scenario
	When I do something
	Then the scenario fails
	And nothing else matters

Scenario Outline: Outline with multiple examples
	Given the first parameter is "<param>"
	And <other param> is the second parameter
	When I do something
	Then the scenario <result>
Examples:
	| param   | other param | result |
	| foo bar | 12          | passes |
	| baz     | 23          | fails  |

Scenario: Scenario with a doc-string
	When I do something
	Then the scenario passes with a doc-string
	"""
	This is a doc-string.
	It can contain multiple lines.
	"""