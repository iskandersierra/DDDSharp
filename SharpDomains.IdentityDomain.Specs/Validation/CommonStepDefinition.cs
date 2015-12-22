using FluentValidation;
using FluentValidation.Results;
using NUnit.Framework;
using SharpDomains.IdentityDomain.Commands;
using SharpDomains.IdentityDomain.Validations;
using System;
using TechTalk.SpecFlow;

namespace SharpDomains.IdentityDomain.Specs.Validation
{
    [Binding]
    public sealed class CommonStepDefinition
    {
        #region [ Common ]
        [When(@"The command is validated")]
        public void WhenTheCommandIsValidated()
        {
            var instance = ScenarioContext.Current.Get<object>();
            var validator = ScenarioContext.Current.Get<IValidator>();
            var validationResult = validator.Validate(instance);
            ScenarioContext.Current.Set(validationResult);
        }

        [Then(@"The validation results has some validation errors")]
        public void TheValidationResultsHasSomeValidationErrors()
        {
            var validationResult = ScenarioContext.Current.Get<ValidationResult>();

            Assert.That(validationResult.IsValid, Is.False);
            Assert.That(validationResult.Errors, Is.Not.Empty);
        }

        [Then(@"The validation results has no validation errors")]
        public void ThenTheValidationResultsHasNoValidationErrors()
        {
            var validationResult = ScenarioContext.Current.Get<ValidationResult>();

            Assert.That(validationResult.IsValid, Is.True);
            Assert.That(validationResult.Errors, Is.Empty);
        }
        #endregion

        [Given(@"A identity related command with an empty IdentityId")]
        public void GivenAIdentityRelatedCommandWithAnEmptyIdentityId()
        {
            ScenarioContext.Current.Set<object>(new ActivateIdentityCommand() { IdentityId = Guid.Empty });
        }

        [Given(@"A identity claim related command with an empty ClaimId")]
        public void GivenAIdentityClaimRelatedCommandWithAnEmptyClaimId()
        {
            ScenarioContext.Current.Set<object>(new RevokeIdentityClaimCommand() { IdentityId = Guid.NewGuid(), ClaimId = 0 });
        }

        [Given(@"A IdentityClaimRelatedCommandValidator is used")]
        public void GivenAIdentityClaimRelatedCommandValidatorIsUsed()
        {
            ScenarioContext.Current.Set<IValidator>(new IdentityClaimRelatedCommandValidator());
        }

        [Given(@"A IdentityRelatedCommandValidator is used")]
        public void GivenAIdentityRelatedCommandValidatorIsUsed()
        {
            ScenarioContext.Current.Set<IValidator>(new IdentityRelatedCommandValidator());
        }

        [Given(@"A CreateIdentityCommand with URI ""(.*)"" is created")]
        public void GivenACreateIdentityCommandWithUriIsCreated(string uri)
        {
            ScenarioContext.Current.Set<object>(new CreateIdentityCommand() {
                UniqueResourceIdentifier = uri
            });
        }

        [Given(@"A CreateIdentityCommandValidator is used")]
        public void GivenACreateIdentityCommandValidatorIsUsed()
        {
            ScenarioContext.Current.Set<IValidator>(new CreateIdentityCommandValidator());
        }
    }
}
