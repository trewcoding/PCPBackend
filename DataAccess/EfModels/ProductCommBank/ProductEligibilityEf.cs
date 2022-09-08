using Newtonsoft.Json;

namespace DataAccess.EfModels.ProductCommBank
{
    public class ProductEligibilityEf
    {
        public Guid EligibilityId { get; set; } = Guid.NewGuid();
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
