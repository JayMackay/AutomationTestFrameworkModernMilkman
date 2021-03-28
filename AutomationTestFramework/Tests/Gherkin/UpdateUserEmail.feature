Feature: UpdateUserEmail
	In order to update my contact details
	As a user
	I want to be able to edit my account email address

Scenario: User inputs an invalid email within account update page
	Given I am on account update page
	When I have entered an invalid email
	Then An error message should be displayed