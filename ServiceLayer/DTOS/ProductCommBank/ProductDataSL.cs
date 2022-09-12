using Newtonsoft.Json;

namespace ServiceLayer.DTOS.ProductCommBank
{
    public class ProductDataSL
    {
        [JsonProperty("features")] 
        public List<ProductFeatureSL> Features { get; set; }

        [JsonProperty("constraints")]
        
        public List<ProductConstraintSL> Constraints { get; set; }

        [JsonProperty("eligibility")]
        
        public List<ProductEligibilitySL> Eligibility { get; set; }

        [JsonProperty("fees")]
        
        public List<ProductFeeSL> Fees { get; set; }

        [JsonProperty("lendingRates")]
        
        public List<ProductLendingRateSL> LendingRates { get; set; }

        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("effectiveFrom")]
        public DateTime EffectiveFrom { get; set; }

        [JsonProperty("effectiveTo")]
        public DateTime EffectiveTo { get; set; }

        [JsonProperty("lastUpdated")]
        public DateTime LastUpdated { get; set; }

        [JsonProperty("productCategory")]
        public string ProductCategory { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("brandName")]
        public string? BrandName { get; set; }

        [JsonProperty("applicationUri")]
        public string? ApplicationUri { get; set; }

        [JsonProperty("isTailored")]
        public bool IsTailored { get; set; }

        [JsonProperty("additionalInformation")]
        
        public ProductAdditionalInformationSL AdditionalInformation { get; set; }
    }
}
