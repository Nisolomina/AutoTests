Feature: Open First English page
	In order to check opening First English page by default
	As a client
	I want to open first English page using different incorrect URLs

Scenario: Open the nonexistent English page
	When I open the site 'http://www.eugenesqr.com/en/posts/808080'
	Then I am able to see 'http://www.eugenesqr.com/en/404.html' url

Scenario: Open First English page if page number is absent
	When I open the site 'http://www.eugenesqr.com/en/posts/'
	Then I am able to see 'http://www.eugenesqr.com/en/posts/1' url

Scenario: Open First English page if post id is absent
	When I open the site 'http://www.eugenesqr.com/en/post/'
	Then I am able to see 'http://www.eugenesqr.com/en/posts/1' url

Scenario: Open First English page if page number is negative number
	When I open the site 'http://www.eugenesqr.com/en/posts/-2'
	Then I am able to see 'http://www.eugenesqr.com/en/posts/1' url

Scenario: Open First English page if page number is not an integer
	When I open the site 'http://www.eugenesqr.com/en/posts/1.05'
	Then I am able to see 'http://www.eugenesqr.com/en/posts/1.05' url

Scenario: Open First English page if page number is Infinity
	When I open the site 'http://www.eugenesqr.com/en/posts/Infinity'
	Then I am able to see 'http://www.eugenesqr.com/en/posts/1' url

Scenario: Open First English page if page number is NaN
	When I open the site 'http://www.eugenesqr.com/en/posts/NaN'
	Then I am able to see 'http://www.eugenesqr.com/en/posts/1' url

Scenario: Open First English page if page number is zero
	When I open the site 'http://www.eugenesqr.com/en/posts/0'
	Then I am able to see 'http://www.eugenesqr.com/en/posts/1' url

Scenario: Open First English page if page number is not a number
	When I open the site 'http://www.eugenesqr.com/en/posts/abrakadabra'
	Then I am able to see 'http://www.eugenesqr.com/en/posts/1' url
