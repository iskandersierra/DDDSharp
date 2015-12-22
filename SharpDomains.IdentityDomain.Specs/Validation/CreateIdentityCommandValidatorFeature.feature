Feature: CreateIdentityCommandValidatorFeature
	In order to process Identity related commands, 
	some validation rules must be enforced

@identitydomain
@validation
@command

Scenario: An Create Identity Command with an invalid Unique Resource Identifier must be rejected
	Given A CreateIdentityCommand with URI "this is an invalid URI" is created
	And A CreateIdentityCommandValidator is used
	When The command is validated
	Then The validation results has some validation errors

Scenario: An Create Identity Command with a valid absolute Unique Resource Identifier must be accepted
	Given A CreateIdentityCommand with URI "http://example.com/people/johnsmith" is created
	And A CreateIdentityCommandValidator is used
	When The command is validated
	Then The validation results has no validation errors

Scenario: An Create Identity Command with a valid URN Unique Resource Identifier must be accepted
	Given A CreateIdentityCommand with URI "urn:example:com:people:johnsmith" is created
	And A CreateIdentityCommandValidator is used
	When The command is validated
	Then The validation results has no validation errors

Scenario: An Create Identity Command with a valid relative Unique Resource Identifier must be accepted
	Given A CreateIdentityCommand with URI "people/johnsmith" is created
	And A CreateIdentityCommandValidator is used
	When The command is validated
	Then The validation results has no validation errors
