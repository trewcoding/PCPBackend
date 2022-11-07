namespace Domain.Entities.Product
{
    public class ProductAdditionalInformation
    {
        public Guid AdditionalInformationId { get; set; }
        public string ProductDataEfProductId { get; set; }
        public string? OverviewUri { get; set; }
        public string? TermsUri { get; set; }
        public string? EligibilityUri { get; set; }
        public string? FeesAndPricingUri { get; set; }
    }
}
