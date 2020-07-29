Feature: Google Page
@mytag
Scenario: test Scenario Ex
	Given open chrome browser
	And enter given url
	| URL                     |
	| https://www.google.com/ |
	When enter username and password
	| username    | password |
	| nam         |    jag   |
	Then sign in page should be displayed