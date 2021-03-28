Feature: UserLogin
	In order to access my account
	As a user
	I want to input my mobile number and password in order to login

Scenario: User inputs valid details within the login page
	Given I am on the login page
	When I have entered all the correct login details
	Then I should be redirected to the user account page