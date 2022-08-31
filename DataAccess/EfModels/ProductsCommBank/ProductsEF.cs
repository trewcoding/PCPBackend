using Newtonsoft.Json;

namespace DataAccess.EfModels.ProductsCommBank
{
    public class ProductsEF
    {
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

        [JsonProperty("isTailored")]
        public bool IsTailored { get; set; }

        [JsonProperty("applicationUri")]
        public string? ApplicationUri { get; set; }

        //[JsonProperty("additionalInformation")]
        //public AdditionalInformationEF AdditionalInformation { get; set; }
    }
}
