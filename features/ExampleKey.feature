Feature: ExampleKey
	
@mytag
Scenario Outline: login with valid credentials
	Given user is on browser
	And user hit the url
	When enter "<mailid>" and "<password>"
	Then the result should be show
	Examples:
	| mailid                            | password |
	|  namratajagtap2020@gmail.com      | hjk      |
