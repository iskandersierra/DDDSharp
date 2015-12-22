namespace SharpDomains.IdentityDomain.Events
{
    public class IdentityCreatedEvent : IdentityRelatedEvent
    {
        public string UniqueResourceIdentifier { get; set; }
    }
}
