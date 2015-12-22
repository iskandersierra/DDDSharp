namespace SharpDomains.IdentityDomain.Commands
{
    public abstract class IdentityClaimRelatedCommand : IdentityRelatedCommand
    {
        public int ClaimId { get; set; }
    }
}
