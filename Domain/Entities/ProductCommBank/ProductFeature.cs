using Newtonsoft.Json;

namespace Domain.Entities.ProductCommBank
{
    public class ProductFeature
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
