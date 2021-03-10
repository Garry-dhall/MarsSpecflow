Feature: Add language in profile details
@mytag
Scenario: Add new language to profile
	Given I am on profile page
	When  I click on language button
	And   I add a new language
	Then  I should be able to see new language in my profile


