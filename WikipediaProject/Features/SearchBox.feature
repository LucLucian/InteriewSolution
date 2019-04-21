Feature: Search Box

@searchBoxTests1
Scenario: Search for "furry rabbits"
	Given I have entered "furry rabbits" text in the search box
	And I have pressed the search button
	When I waited to get the searched results
	Then the page should contain a "Did you mean" suggestion

@searchBoxTests2
Scenario: Check Wikipedia suggestion search results
	Given I have searched for "furry rabbits" in the search box
	And I waited to get the searched results
	When I clicked on the "Did you mean" suggestion 
	Then the page should contain  20 search results

@searchBoxTest3
Scenario: Check the page content from a search result article
	Given I have entered "furry rabbits" text in the search box and waited for search results
	And  I clicked on the "Did you mean" link suggestion
	When I clicked on the first result i got on that suggestion
	Then the page article should contain a standard wikipedia Title and a Table of content