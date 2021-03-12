Feature: Skills
	Simple calculator for adding two numbers

@mytag
Scenario: (1) Add new skill
	Given I am on profile page
	When  I click on skills
	And   I enter new skill details
	And   I click on add button
	Then  I should be able to see added skill
@smoke
Scenario: (2) Edit Skill
Given    I am on Profile page 
When     I click on skills
And      I click on edit button
And      I edit the skill name and level
And      I click on Update
Then     I sould be able to see updated skill

#Scenario: (3) Delete Skill
#Given    I am on profile page
#When     I click on skills
#And      I click on cross button
#Then     I should be able to see skill deleted