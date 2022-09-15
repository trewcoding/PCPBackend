namespace ServiceLayer.DTOS.Product
{
    public class ProductDataSl
    {      
        public List<ProductFeatureSl> Features { get; set; }       
        public List<ProductConstraintSl> Constraints { get; set; }
        public List<ProductEligibilitySl> Eligibility { get; set; }
        public List<ProductFeeSl> Fees { get; set; }
        public List<ProductLendingRateSl> LendingRates { get; set; }
        public string ProductId { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveTo { get; set; }
        public DateTime LastUpdated { get; set; }
        public string ProductCategory { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string? BrandName { get; set; }
        public string? ApplicationUri { get; set; }
        public bool IsTailored { get; set; }
        public ProductAdditionalInformationSl AdditionalInformation { get; set; }
    }
}
