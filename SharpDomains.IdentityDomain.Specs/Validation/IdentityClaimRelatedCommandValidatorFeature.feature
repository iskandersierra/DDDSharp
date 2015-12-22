Feature: IdentityClaimRelatedCommandValidatorFeature
	In order to process Identity claim related commands, 
	some validation rules must be enforced

@identitydomain
@validation
@command

Scenario: An identity claim related command with an empty ClaimId is invalid
	Given A identity claim related command with an empty ClaimId
	And A IdentityClaimRelatedCommandValidator is used
	When The command is validated
	Then The validation results has some validation errors
