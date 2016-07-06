Feature: FirstFeature
	In order to navigate to Specflow-Excel documentation
	As a Specflow user
	I want to Select Specflow+-->Specflow+-Excel

@mytag
Scenario: Navigate to Specflow+
	Given the specflow page
	When I press SpecFlow+
	And Specflow+-Excel
	Then I am able to see 'Get Started Now with Specflow+ Excel!' button
