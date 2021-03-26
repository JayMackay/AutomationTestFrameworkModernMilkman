Feature: PostcodeValidationTest
	In order to check if the service is available in my area
	As a user
	I want to input my postcode and be directed to the registration page once I click search

Scenario: User inputs a valid postcode where the service is available
	Given I have inputted a valid postcode
	When I click the Find button
	Then I should be redirected to the registration page