Feature: Change language
	In order to change language from Russian to English and backwards
	As a client
	I want to select buttons "RU" and "EN"

@mytag
Scenario: Change language from Russian to English
	Given I open the site 'http://www.eugenesqr.com/ru/posts/1'
	When I press button 'EN'
	Then I am able to see 'http://www.eugenesqr.com/en/posts/1' url

Scenario: Change language from English to Russian
	Given I open the site 'http://www.eugenesqr.com/en/posts/1'
	When I press button 'RU'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url
