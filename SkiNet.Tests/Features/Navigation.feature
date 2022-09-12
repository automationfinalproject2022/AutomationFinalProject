Feature: Navigation

Scenarios for navigation in SkiNet site

Scenario: Validate Login page is opened
	Given Home page is displayed
	When The "Login" page is opened
	Then The page title should be "Login"

Scenario: Validate Login page is opened (parametrized)
	Given Home page is displayed
	When The Login page is opened
	Then The page title should be Login


Scenario Outline: Validate correct page is opened
	Given Home page is displayed
	When The <pageName> page is opened
	Then The page title should be <pageName>

Examples:
	| pageName |
	| Login    |
	| Shop     |
	| Errors   |
