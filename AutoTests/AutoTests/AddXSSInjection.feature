Feature: Add XSS injection
	In order to check if the site may be attacked with XSS injections
	As a client
	I want to add diffirent XSS ingections

Scenario: Add injection <script>alert("Hello")</script> after postId
	When I open the site 'http://www.eugenesqr.com/ru/posts/1<script>alert("Hello")</script>'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Add injection <script>alert("Hello")</script> after language
	When I open the site 'http://www.eugenesqr.com/ru<script>alert("Hello")</script>'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Add injection quotes"><script>alert("Hello")</script> after postId
	When I open the site 'http://www.eugenesqr.com/ru/posts/1"><script>alert("Hello")</script>'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Add injection quotes"><script>alert("Hello")</script> after language
	When I open the site 'http://www.eugenesqr.com/ru"><script>alert("Hello")</script>'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Add injection apostrophes '><''>"><script>alert("Hello")</script> after postId
	When I open the site 'http://www.eugenesqr.com/ru/posts/1‘><‘‘>"><script>alert("Hello")</script>''
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url

Scenario: Add injection apostrophes'>><''>"><script>alert("Hello")</script> after language
	When I open the site 'http://www.eugenesqr.com/ru‘><‘‘>"><script>alert("Hello")</script>'
	Then I am able to see 'http://www.eugenesqr.com/ru/posts/1' url