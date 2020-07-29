Feature: login page with multiple data

@mytag
Scenario: check multiple data
	Given open ch browser
	And enter url in search bar
	| URL                     |
	| https://www.google.com/ |
	When enter multiple data
	|name | phoneno| add  |
    |bjkbd| 09876   | pun  |
    |hjkds| 9087    | delhi|
	Then result with multiple data should be displayed
