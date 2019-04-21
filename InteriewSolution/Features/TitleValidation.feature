Feature: Title Validation

@pageTitleTest
Scenario: Checks Wikipedia title on the Main page
	Given I have reached to Wikipedia Home page and waited for the page to be fully loaded
	When I checked the Main title of the page
	Then the title displayed should be "Wikipedia"