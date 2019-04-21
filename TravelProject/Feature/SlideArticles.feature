Feature: Check dinamic slider functionality depending on window size

@slidertest
Scenario: Check slider functionality on mobile
	Given I have reahed travelex homepage
	And I have resized the browser window to 550 px wide
	And I have scrolled down to the first slider
	When I slide two times to the left
	Then the third slide should be displayed