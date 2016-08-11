Feature: Open listing page
	In order to check content of opened page
	As a client
	I want to open page using buttons and URLs

Scenario: See the Older button
	When I open the site 'http://www.eugenesqr.com/en/posts/1'
	Then I am able to see Older button

Scenario: See the Newer button
	When I open the site 'http://www.eugenesqr.com/en/posts/1'
	Then I am able to see Newer button

Scenario: Open the older English page
	Given I open the site 'http://www.eugenesqr.com/en/posts/1'
	When I press button to see earlier English posts
	Then I am able to see 'http://www.eugenesqr.com/en/posts/2' url

Scenario: Open the newer English page
	Given I open the site 'http://www.eugenesqr.com/en/posts/2'
	When I press button to see newer English posts
	Then I am able to see 'http://www.eugenesqr.com/en/posts/1' url
	
Scenario: Open the nonexistent English page
	When I open the site 'http://www.eugenesqr.com/en/posts/808080'
	Then I am able to see 'http://www.eugenesqr.com/en/404.html' url

Scenario: Open the older Russian page
	Given I open the site 'http://www.eugenesqr.com/ru/posts/1'
	When I press button to see earlier Russian posts
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/2' url

Scenario: Open the newer Russian page
	Given I open the site 'http://www.eugenesqr.com/ru/posts/2'
	When I press button to see newer Russian posts
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Open the nonexistent Russian page
	When I open the site 'http://www.eugenesqr.com/ru/posts/808080'
	Then I am able to see 'http://www.eugenesqr.com/ru/404.html' url

Scenario: Open First Russian page if page number is absent
	When I open the site 'http://www.eugenesqr.com/ru/posts/'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Open First English page if page number is absent
	When I open the site 'http://www.eugenesqr.com/en/posts/'
	Then I am able to see 'http://www.eugenesqr.com/en/posts/1' url

Scenario: Open First Russian page if post id is absent
	When I open the site 'http://www.eugenesqr.com/ru/post/'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Open First English page if post id is absent
	When I open the site 'http://www.eugenesqr.com/en/post/'
	Then I am able to see 'http://www.eugenesqr.com/en/posts/1' url

