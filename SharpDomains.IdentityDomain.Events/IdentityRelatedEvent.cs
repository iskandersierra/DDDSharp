using System;

namespace SharpDomains.IdentityDomain.Events
{
    public abstract class IdentityRelatedEvent
    {
        public Guid IdentityId { get; set; }
    }
}
