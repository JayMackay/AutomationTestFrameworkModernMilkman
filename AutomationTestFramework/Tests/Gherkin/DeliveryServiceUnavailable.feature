Feature: DeliveryServiceUnavailable
	In order to check if the service is unavailable in my area
	As a user
	I want to input my postcode and be directed to the notification signup page once I click search

Scenario: User inputs a valid postcode where the service is unavailable
	Given I have inputted a valid unavailable postcode
	When I input a postcode where the service is unavailable and click find
	Then I should be redirected to the service unavailable page