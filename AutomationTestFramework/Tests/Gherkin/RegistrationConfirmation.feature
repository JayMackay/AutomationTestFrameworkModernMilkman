Feature: RegistrationConfirmation
	In order to utilize the service
	As a user
	I want to input my postcode and be directed to the notification signup page once I click search

Scenario: User inputs valid details within the registration page
	Given I am on the registration page for a new user
	When I have entered all the correct details within the form
	Then I should be logged in as new user