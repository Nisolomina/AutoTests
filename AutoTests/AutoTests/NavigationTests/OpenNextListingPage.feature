Feature: Open next listing page
	In order to check content of next page
	As a client
	I want to open next page using buttons and URLs

Scenario: See the Older button
	When I open the site 'http://www.eugenesqr.com/en/posts/1'
	Then I am able to see Older button

Scenario: Open the older English page
	Given I open the site 'http://www.eugenesqr.com/en/posts/1'
	When I press button to see earlier English posts
	Then I am able to see 'http://www.eugenesqr.com/en/posts/2' url
	
Scenario: Open the older Russian page
	Given I open the site 'http://www.eugenesqr.com/ru/posts/1'
	When I press button to see earlier Russian posts
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/2' url


