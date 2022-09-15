namespace DataAccess.EfModels.Product
{
    public class ProductDataEf
    {
        public List<ProductFeatureEf>? Features { get; set; }
        public List<ProductConstraintEf>? Constraints { get; set; }
        public List<ProductEligibilityEf>? Eligibility { get; set; }
        public List<ProductFeeEf>? Fees { get; set; }
        public List<ProductLendingRateEf>? LendingRates { get; set; }
        public string? ProductId { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveTo { get; set; }
        public DateTime LastUpdated { get; set; }
        public string? ProductCategory { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Brand { get; set; }
        public string ?BrandName { get; set; }
        public string ?ApplicationUri { get; set; }
        public bool IsTailored { get; set; }
        public ProductAdditionalInformationEf? AdditionalInformation { get; set; }
    }
}
