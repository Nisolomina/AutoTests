Feature: Change locale in URL of First Page
	In order to change URL using different locale on First page
	As a client
	I want to see first page content in Russian or in English languges 

Scenario: Open First Russian Page by default
	When I open the site 'http://www.eugenesqr.com'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Open First Russian Page if locale is absent
	When I open the site 'http://www.eugenesqr.com//posts/1'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Open First Russian Page if Russian locale in url
	When I open the site 'http://www.eugenesqr.com/ru/posts'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Open First English Page if English locale in url
	When I open the site 'http://www.eugenesqr.com/en/posts'
	Then I am able to see 'http://www.eugenesqr.com/en/posts/1' url

Scenario: Open First Russian Page if different locale in url
	When I open the site 'http://www.eugenesqr.com/es/posts'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Open First Russian Page if unknown locale in url
	When I open the site 'http://www.eugenesqr.com/abrakadabra/posts'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url
