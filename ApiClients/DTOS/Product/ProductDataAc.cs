using Newtonsoft.Json;

namespace ApiClients.DTOS.Product
{
    public class ProductDataAc
    {
        [JsonProperty("features")]

        public List<ProductFeatureAc> Features { get; set; }

        [JsonProperty("constraints")]

        public List<ProductConstraintAc> Constraints { get; set; }

        [JsonProperty("eligibility")]

        public List<ProductEligibilityAc> Eligibility { get; set; }

        [JsonProperty("fees")]

        public List<ProductFeeAc> Fees { get; set; }

        [JsonProperty("lendingRates")]

        public List<ProductLendingRateAc> LendingRates { get; set; }

        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("effectiveFrom")]
        public DateTime? EffectiveFrom { get; set; }

        [JsonProperty("effectiveTo")]
        public DateTime? EffectiveTo { get; set; }

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

        public ProductAdditionalInformationAc AdditionalInformation { get; set; }
    }
}
