Feature: ContactUs
As a user
I want to be able to work with Contact Us section
o I can message customer support
        

@mytag
Scenario: User can send message via contact us form
	Given  user opent contact us page
	When user enters all required fields
		And user submits contacts us form
		And confirms the promp message
	Then user will receive 'Success! Your details have been submitted successfully.' message