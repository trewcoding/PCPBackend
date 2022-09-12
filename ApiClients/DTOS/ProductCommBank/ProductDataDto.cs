using Newtonsoft.Json;

namespace ApiCients.DTOS.ProductCommBank
{
    public class ProductDataDto
    {
        [JsonProperty("features")] 
        public List<ProductFeatureDto> Features { get; set; }

        [JsonProperty("constraints")]
        
        public List<ProductConstraintDto> Constraints { get; set; }

        [JsonProperty("eligibility")]
        
        public List<ProductEligibilityDto> Eligibility { get; set; }

        [JsonProperty("fees")]
        
        public List<ProductFeeDto> Fees { get; set; }

        [JsonProperty("lendingRates")]
        
        public List<ProductLendingRateDto> LendingRates { get; set; }

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
        
        public ProductAdditionalInformationDto AdditionalInformation { get; set; }
    }
}
