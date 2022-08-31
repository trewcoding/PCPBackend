using Newtonsoft.Json;

namespace ApiClients.DTOS.ProductCommBank
{
    public class ProductEligibilityDto
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
