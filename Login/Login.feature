Feature: Login

Users are able to logged in 
@tag1
Scenario Outline: User can login with correct details
	Given I am on Login Page
	When User enters login Details <Username>
	And User enters password details <Password>
	And User click submit
	Then User gets logged In

	Examples: 
	| Username                 | Password    |
	| sabamasoom01@hotmail.com | P@ssword123 |

