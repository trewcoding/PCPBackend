using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.ProductCommBank
{
    public class ProductFeature
    {
        [Key]
        public Guid FeatureId { get; set; }
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
