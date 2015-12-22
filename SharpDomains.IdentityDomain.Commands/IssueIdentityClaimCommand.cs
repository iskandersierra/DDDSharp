namespace SharpDomains.IdentityDomain.Commands
{
    public class IssueIdentityClaimCommand : IdentityRelatedCommand
    {
        public string Issuer { get; set; }

        public string OriginalIssuer { get; set; }

        public string Type { get; set; }

        public string Value { get; set; }

        public string ValueType { get; set; }
    }
}
