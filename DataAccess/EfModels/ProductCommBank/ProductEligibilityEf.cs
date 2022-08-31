using Newtonsoft.Json;

namespace DataAccess.EfModels.ProductCommBank
{
    public class ProductEligibilityEf
    {
        [JsonProperty("eligibilityType")]
        public string EligibilityType { get; set; }

        [JsonProperty("additionalValue")]
        public string AdditionalValue { get; set; }

        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }

        [JsonProperty("discountEligibilityType")]
        public string DiscountEligibilityType { get; set; }
    }
}
