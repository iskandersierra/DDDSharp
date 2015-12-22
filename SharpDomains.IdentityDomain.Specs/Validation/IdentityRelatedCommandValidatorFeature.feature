Feature: IdentityRelatedCommandValidatorFeature
	In order to process Identity related commands, 
	some validation rules must be enforced

@identitydomain
@validation
@command

Scenario: An identity related command with an empty IdentityId is invalid
	Given A identity related command with an empty IdentityId
	And A IdentityRelatedCommandValidator is used
	When The command is validated
	Then The validation results has some validation errors
