Feature: Open First Russian page
	In order to check opening First Russian page by default
	As a client
	I want to open first russian page using different incorrect URLs

Scenario: Open the nonexistent Russian page
	When I open the site 'http://www.eugenesqr.com/ru/posts/808080'
	Then I am able to see 'http://www.eugenesqr.com/ru/404.html' url

Scenario: Open First Russian page if page number is absent
	When I open the site 'http://www.eugenesqr.com/ru/posts/'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Open First Russian page if post id is absent
	When I open the site 'http://www.eugenesqr.com/ru/post/'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Open First Russian page if page number is negative number
	When I open the site 'http://www.eugenesqr.com/ru/posts/-2'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Open First Russian page if page number is not an integer
	When I open the site 'http://www.eugenesqr.com/ru/posts/1.22'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1.22' url

Scenario: Open First Russian page if page number is Infinity
	When I open the site 'http://www.eugenesqr.com/ru/posts/Infinity'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Open First Russian page if page number is Nan
	When I open the site 'http://www.eugenesqr.com/ru/posts/NaN'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Open First Russian page if page number is zero
	When I open the site 'http://www.eugenesqr.com/ru/posts/0'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Open First Russian page if page number is not a number
	When I open the site 'http://www.eugenesqr.com/ru/posts/abrakadabra'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

