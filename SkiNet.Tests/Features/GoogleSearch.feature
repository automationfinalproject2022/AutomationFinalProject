Feature: GoogleSearch

Scenarios for google search feature

@tag1
Scenario: Search for Selenium and open Wikipedia
	Given The Google home page is displayed
	When The user searches for "Selenium Wikipedia"
	And The user clicks of the first result
	Then The Wikipedia Heading should be "Selenium"
	And The Contents should have "Characteristics"
	But the Contents should not have "Selenium"
