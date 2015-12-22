using System;
namespace SharpDomains.IdentityDomain.Commands
{
    public abstract class IdentityRelatedCommand
    {
        public Guid IdentityId { get; set; }
    }
}