Feature: Login
	Login to EA Demo application

@smoke
Scenario: Perform Login of EA Application site
    Given I launch the application
	And I have enter login details
   Then I should see Employee details link
