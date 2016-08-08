Feature: Change language
	In order to change language from Russian to English and backwards
	As a client
	I want to see site content in Russian or in English languges 

Scenario: Change language from Russian to English
	Given I open the site 'http://www.eugenesqr.com/ru/posts/1'
	When I press button to change language to English
	Then I am able to see 'http://www.eugenesqr.com/en/posts/1' url

Scenario: Change language from English to Russian
	Given I open the site 'http://www.eugenesqr.com/en/posts/1'
	When I press button to change language to Russian
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Open Main Russian Page by default
	When I open the site 'http://www.eugenesqr.com'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Open Main English Page if English locale in url
	When I open the site 'http://www.eugenesqr.com/en/posts'
	Then I am able to see 'http://www.eugenesqr.com/en/posts/1' url

Scenario: Open Main Russian Page if Spain locale in url
	When I open the site 'http://www.eugenesqr.com/es/posts'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Open Main Russian Page if unknown locale in url
	When I open the site 'http://www.eugenesqr.com/abrakadabra/posts'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url
