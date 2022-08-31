using Newtonsoft.Json;

namespace DataAccess.EfModels.ProductCommBank
{
    public class ProductDataEf
    {
        [JsonProperty("features")]
        public List<ProductFeatureEf> Features { get; set; }

        [JsonProperty("constraints")]
        public List<ProductConstraintEf> Constraints { get; set; }

        [JsonProperty("eligibility")]
        public List<ProductEligibilityEf> Eligibility { get; set; }

        [JsonProperty("fees")]
        public List<ProductFeeEf> Fees { get; set; }

        [JsonProperty("lendingRates")]
        public List<ProductLendingRateEf> LendingRates { get; set; }

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
        public string BrandName { get; set; }

        [JsonProperty("applicationUri")]
        public string ApplicationUri { get; set; }

        [JsonProperty("isTailored")]
        public bool IsTailored { get; set; }

        [JsonProperty("additionalInformation")]
        public ProductAdditionalInformationEf AdditionalInformation { get; set; }
    }
}
