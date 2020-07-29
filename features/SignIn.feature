Feature: SignIn for POM
	

@mytag
Scenario Outline: SignIn Page
	Given user open browser for POM
	And user open url
	When  user enter "<text>"
	Then user navigate to another page
	Examples: 
	| text        |
	| selenium    |