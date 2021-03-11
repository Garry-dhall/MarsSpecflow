Feature: Availibility
	Simple calculator for adding two numbers

@mytag
Scenario: Select availability on profile page

   Given  I am on profile page
    When  I click on edit button next to availibility 
	And   I select availibility
    Then  I should be able to see selected availibility on profile


Scenario: Select hours in profile page
   Given  I am on profile page 
   When   I click on edit button next to hours
   And    I select hours 
   Then  I should be able to see selected hours on profile 

Scenario: Select Earn Target in Profile page
    Given  I am on profile page 
     When  I click on edit button next to EarnTarget
     And   I select EarnTarget
     Then I should be able to see selected EarnTarget on profile 



  