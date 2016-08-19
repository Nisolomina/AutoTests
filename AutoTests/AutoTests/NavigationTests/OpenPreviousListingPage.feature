Feature: Open previous listing page
	In order to check content of previous page
	As a client
	I want to open previous page using buttons and URLs

Scenario: See the Newer button
	When I open the site 'http://www.eugenesqr.com/en/posts/1'
	Then I am able to see Newer button

Scenario: Open the newer English page
	Given I open the site 'http://www.eugenesqr.com/en/posts/2'
	When I press button to see newer English posts
	Then I am able to see 'http://www.eugenesqr.com/en/posts/1' url

Scenario: Open the newer Russian page
	Given I open the site 'http://www.eugenesqr.com/ru/posts/2'
	When I press button to see newer Russian posts
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url
