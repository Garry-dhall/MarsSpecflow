Feature: SignIn
	Simple calculator for adding two numbers


Scenario: Validate SignIn Feature
	Given I am on homepage
	When  I click on SignIn button
	And   I enter valid credentials
	| Email                  | Password |
	| garrydhallnz@gmail.com | Test@123 |
	And   I click on Login Button
	Then  I should be able to login successfully