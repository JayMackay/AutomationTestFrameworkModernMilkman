Feature: ServiceCheckFeature
	In order to check if the service is available in my area
	As a user
	I want to input my postcode and be directed to the registration page once I click search

Scenario: User inputs a valid postcode where the service is available
	Given I am on the website main home page
	When I input a valid postcode
	And The service is avaiable in my area
	And I click the "Find" button
	Then I should be redirected to the registration page

Scenario: User inputs a valid postcode where the service is unavailable
	Given I am on the website main home page
	When I input a valid postcode
	And the service is unavailable in my area
	And I click the "Find" button
	Then I should be redirected to the service unavailable page

Scenario: User inputs an invalid postcode
	Given I am on the website main home page
	When I input an invalid postcode
	And I click the "Find" button
	Then An error message will be displayed
