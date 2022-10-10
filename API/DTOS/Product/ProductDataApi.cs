using Newtonsoft.Json;

namespace API.DTOS.Product
{
    public class ProductDataApi
    {
        [JsonProperty("features")]

        public List<ProductFeatureApi> Features { get; set; }

        [JsonProperty("constraints")]

        public List<ProductConstraintApi> Constraints { get; set; }

        [JsonProperty("eligibility")]

        public List<ProductEligibilityApi> Eligibility { get; set; }

        [JsonProperty("fees")]

        public List<ProductFeeApi> Fees { get; set; }

        [JsonProperty("lendingRates")]

        public List<ProductLendingRateApi> LendingRates { get; set; }

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

        public ProductAdditionalInformationApi AdditionalInformation { get; set; }
    }
}
