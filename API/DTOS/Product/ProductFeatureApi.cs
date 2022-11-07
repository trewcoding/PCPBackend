using Newtonsoft.Json;

namespace API.DTOS.Product
{
    public class ProductFeatureApi
    {
        public Guid FeatureId { get; set; }
        [JsonProperty("productDataEfProductId")]
        public string? ProductDataEfProductId { get; set; }
        [JsonProperty("featureType")]
        public string? FeatureType { get; set; }

        [JsonProperty("additionalValue")]
        public string? AdditionalValue { get; set; }

        [JsonProperty("additionalInfo")]
        public string? AdditionalInfo { get; set; }

        [JsonProperty("additionalInfoUri")]
        public string? AdditionalInfoUri { get; set; }
    }
}
