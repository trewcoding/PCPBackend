namespace Domain.Entities.Product
{
    public class ProductData
    {
        public List<ProductFeature>? Features { get; set; }
        public List<ProductConstraint>? Constraints { get; set; }
        public List<ProductEligibility>? Eligibility { get; set; }
        public List<ProductFee>? Fees { get; set; }
        public List<ProductLendingRate>? LendingRates { get; set; }
        public string ProductId { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveTo { get; set; }
        public DateTime LastUpdated { get; set; }
        public string? ProductCategory { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Brand { get; set; }
        public string? BrandName { get; set; }
        public string? ApplicationUri { get; set; }
        public bool IsTailored { get; set; }
        public ProductAdditionalInformation AdditionalInformation { get; set; }
    }
}
