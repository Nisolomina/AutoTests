Feature: Change locale in URL of Post Page
	In order to change URL using different locale on post page
	As a client
	I want to see post content in Russian or in English languges 

Scenario: Open Russian post by default
	When I open the site 'http://www.eugenesqr.com//post/second-iteration-completed'
	Then I am able to see 'http://www.eugenesqr.com/ru/post/second-iteration-completed' url

Scenario: Open Russian post if Russian locale in url
	When I open the site 'http://www.eugenesqr.com/ru/post/second-iteration-completed'
	Then I am able to see 'http://www.eugenesqr.com/ru/post/second-iteration-completed' url

Scenario: Open English post if English locale in url
	When I open the site 'http://www.eugenesqr.com/en/post/second-iteration-completed'
	Then I am able to see 'http://www.eugenesqr.com/en/post/second-iteration-completed' url

Scenario: Open Russian post if different locale in url
	When I open the site 'http://www.eugenesqr.com/es/post/second-iteration-completed'
	Then I am able to see 'http://www.eugenesqr.com/ru/post/second-iteration-completed' url

Scenario: Open Russian post if unknown locale in url
	When I open the site 'http://www.eugenesqr.com/abrakadabra/post/second-iteration-completed'
	Then I am able to see 'http://www.eugenesqr.com/ru/post/second-iteration-completed' url
