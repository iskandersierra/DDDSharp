using FluentValidation;
using SharpDomains.IdentityDomain.Commands;

namespace SharpDomains.IdentityDomain.Validations
{
    public class IdentityClaimRelatedCommandValidator :
        AbstractValidator<IdentityClaimRelatedCommand>
    {
        public IdentityClaimRelatedCommandValidator()
        {
            RuleFor(c => c.ClaimId).GreaterThan(0);
        }
    }
}
