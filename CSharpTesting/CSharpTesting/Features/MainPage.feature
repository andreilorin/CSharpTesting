Feature: MainPage

@mytag
Scenario: Navigate to the main page
	Given Main Page is accesed
	When Contact button is pressed
	Then Contact section is displayed
