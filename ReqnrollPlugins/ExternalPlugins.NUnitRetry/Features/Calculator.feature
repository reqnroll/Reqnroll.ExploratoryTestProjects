@Retry
Feature: Retryable Feature

Scenario: Retry scenario three times by default
	When I increment the retry count
	Then the result should be 3