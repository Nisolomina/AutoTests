Feature: Change language of First page
	In order to change language from Russian to English and backwards on First page
	As a client
	I want to see First page content in Russian or in English languges 

Scenario: Change language of First page from Russian to English
	Given I open the site 'http://www.eugenesqr.com/ru/posts/1'
	When I press button to change language to English on First Page
	Then I am able to see 'http://www.eugenesqr.com/en/posts/1' url

Scenario: Change language of First page from English to Russian
	Given I open the site 'http://www.eugenesqr.com/en/posts/1'
	When I press button to change language to Russian on First Page
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Open First Russian Page by default
	When I open the site 'http://www.eugenesqr.com'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Open First Russian Page if locale is absent
	When I open the site 'http://www.eugenesqr.com//posts/1'
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
