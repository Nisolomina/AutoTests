Feature: Open page
	In order to check content of opened page
	As a client
	I want to open page using buttons and URLs

Scenario: Open the older page
	Given I open the site 'http://www.eugenesqr.com/en/posts/1'
	When I press button to see earlier posts
	Then I am able to see 'http://www.eugenesqr.com/en/posts/2' url

Scenario: Open the newer page
	Given I open the site 'http://www.eugenesqr.com/en/posts/2'
	When I press button to see newer posts
	Then I am able to see 'http://www.eugenesqr.com/en/posts/1' url


