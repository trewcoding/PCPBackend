using Newtonsoft.Json;

namespace API.DTOS.Product
{
    public class ProductEligibilityApi
    {
        public Guid EligibilityId { get; set; }
        [JsonProperty("productDataEfProductId")]
        public string ProductDataEfProductId { get; set; }
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
