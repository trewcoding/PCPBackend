using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.EfModels.ProductCommBank
{
    public class ProductFeatureEf
    {
        public Guid FeatureId { get; set; } = Guid.NewGuid();
        [JsonProperty("featureType")]
        public string FeatureType { get; set; }

        [JsonProperty("additionalValue")]
        public string AdditionalValue { get; set; }

        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }

        [JsonProperty("additionalInfoUri")]
        public string AdditionalInfoUri { get; set; }

        //public string ProductIdForeginKey { get; set; }
        //public ProductDataEf ProductDataEf { get; set; }

        //public string ProductId { get; set; }

    }
}
