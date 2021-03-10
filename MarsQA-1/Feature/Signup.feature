Feature: Signup 
	Simple calculator for adding two numbers


Scenario: Validate Registeration feature
	Given I am on home page
	When  I clicked on Join button
	And   I Enter valid credentials 
	And   I click on join button
	Then  I should be able to Register successfully.