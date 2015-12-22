using System;
using FluentValidation;
using SharpDomains.IdentityDomain.Commands;

namespace SharpDomains.IdentityDomain.Validations
{
    public class CreateIdentityCommandValidator :
        AbstractValidator<CreateIdentityCommand>
    {
        public CreateIdentityCommandValidator()
        {
            RuleFor(c => c.UniqueResourceIdentifier).Must(BeAValidUri);
        }

        private bool BeAValidUri(string arg)
        {
            return Uri.IsWellFormedUriString(arg, UriKind.RelativeOrAbsolute);
        }
    }
}
