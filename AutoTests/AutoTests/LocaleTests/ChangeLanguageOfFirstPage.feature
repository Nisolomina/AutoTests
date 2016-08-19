Feature: Change language of First page
	In order to change language from Russian to English and backwards on First page
	As a client
	I want to see First page content in Russian or in English languges 

Scenario: See the En button on First English Page
	When I open the site 'http://www.eugenesqr.com/en/posts/1'
	Then I am able to see EN button

Scenario: See the RU button on First English Page
	When I open the site 'http://www.eugenesqr.com/en/posts/1'
	Then I am able to see RU button

Scenario: See the En button on First Russian Page
	When I open the site 'http://www.eugenesqr.com/ru/posts/1'
	Then I am able to see EN button

Scenario: See the RU button on First Russian Page
	When I open the site 'http://www.eugenesqr.com/ru/posts/1'
	Then I am able to see RU button

Scenario: Change language of First page from Russian to English
	Given I open the site 'http://www.eugenesqr.com/ru/posts/1'
	When I press button to change language to English on First Page
	Then I am able to see 'http://www.eugenesqr.com/en/posts/1' url

Scenario: Change language of First page from English to Russian
	Given I open the site 'http://www.eugenesqr.com/en/posts/1'
	When I press button to change language to Russian on First Page
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url
