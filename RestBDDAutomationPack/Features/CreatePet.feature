Feature: CreatePet
	
@mytag
Scenario: Create Pet
	Given the valid user with login credintials
	When the create request triggered
	Then the result should be success
	And the details should be correct