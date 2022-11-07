namespace DataAccess.EfModels.Product
{
    public class ProductAdditionalInformationEf
    {
        public Guid AdditionalInformationId { get; set; } = Guid.NewGuid();
        public string? ProductDataEfProductId { get; set; }
        public string? OverviewUri { get; set; }
        public string? TermsUri { get; set; }
        public string? EligibilityUri { get; set; }
        public string? FeesAndPricingUri { get; set; }
    }
}
