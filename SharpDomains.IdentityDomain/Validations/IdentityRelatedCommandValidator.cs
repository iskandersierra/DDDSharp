using System;
using FluentValidation;
using SharpDomains.IdentityDomain.Commands;

namespace SharpDomains.IdentityDomain.Validations
{
    public class IdentityRelatedCommandValidator : 
        AbstractValidator<IdentityRelatedCommand>
    {
        public IdentityRelatedCommandValidator()
        {
            RuleFor(c => c.IdentityId).NotEmpty();
        }
    }
}
