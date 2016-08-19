Feature: Change language of Post Page
	In order to change language from Russian to English and backwards on post page
	As a client
	I want to see post content in Russian or in English languges 

Scenario: See the En button on English Post
	When I open the site 'http://www.eugenesqr.com/en/post/second-iteration-completed'
	Then I am able to see EN button

Scenario: See the RU button on English Post
	When I open the site 'http://www.eugenesqr.com/en/post/second-iteration-completed'
	Then I am able to see RU button

Scenario: See the En button on Russian Post
	When I open the site 'http://www.eugenesqr.com/ru/post/second-iteration-completed'
	Then I am able to see EN button

Scenario: See the RU button on Russian Post
	When I open the site 'http://www.eugenesqr.com/ru/post/second-iteration-completed'
	Then I am able to see RU button

Scenario: Change language of post from Russian to English
	Given I open the site 'http://www.eugenesqr.com/ru/post/second-iteration-completed'
	When I press button to change language to English on post page
	Then I am able to see 'http://www.eugenesqr.com/en/post/second-iteration-completed' url

Scenario: Change language of post from English to Russian
	Given I open the site 'http://www.eugenesqr.com/en/post/second-iteration-completed'
	When I press button to change language to Russian on post page
	Then I am able to see 'http://www.eugenesqr.com/ru/post/second-iteration-completed' url
