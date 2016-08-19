Feature: Open post
	In order to check content of opened post
	As a client
	I want to open post using links and URLs

Scenario: Open the Russian post
	Given I open the site 'http://www.eugenesqr.com/ru/posts/1'
	When I click on link of Russian post 'second-iteration-completed'
	Then I am able to see 'http://www.eugenesqr.com/ru/post/second-iteration-completed' url

Scenario: Open the English post
	Given I open the site 'http://www.eugenesqr.com/en/posts/1'
	When I click on link of English post 'second-iteration-completed'
	Then I am able to see 'http://www.eugenesqr.com/en/post/second-iteration-completed' url

Scenario: Open nonexistent Russian post
	When I open the site 'http://www.eugenesqr.com/ru/post/abrakadabra'
	Then I am able to see 'http://www.eugenesqr.com/ru/404.html' url

Scenario: Open nonexistent English post
	When I open the site 'http://www.eugenesqr.com/en/post/abrakadabra'
	Then I am able to see 'http://www.eugenesqr.com/en/404.html' url