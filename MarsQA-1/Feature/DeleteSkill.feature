Feature: DeleteSkill
	Simple calculator for adding two numbers

@mytag
Scenario: Deleteing Skill
	Given I am on profile page
	When  I do click on skills
	And   I select delete button
	Then  Skill should be deleted
