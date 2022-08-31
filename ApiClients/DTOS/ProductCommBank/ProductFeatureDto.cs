using Newtonsoft.Json;

namespace ApiClients.DTOS.ProductCommBank
{
    public class ProductFeatureDto
    {
        [JsonProperty("featureType")]
        public string FeatureType { get; set; }

        [JsonProperty("additionalValue")]
        public string AdditionalValue { get; set; }

        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }

        [JsonProperty("additionalInfoUri")]
        public string AdditionalInfoUri { get; set; }
    }
}
