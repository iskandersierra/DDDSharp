namespace SharpDomains.IdentityDomain.Events
{
    public abstract class IdentityClaimRelatedEvent : IdentityRelatedEvent
    {
        public int ClaimId { get; set; }
    }
}
