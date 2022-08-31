using Newtonsoft.Json;

namespace DataAccess.EfModels.ProductCommBank
{
    public class ProductConstraintEf
    {
        [JsonProperty("constraintType")]
        public string ConstraintType { get; set; }

        [JsonProperty("additionalValue")]
        public string AdditionalValue { get; set; }

        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
    }
}
