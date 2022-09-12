using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ApiCients.DTOS.ProductCommBank
{
    public class ProductEligibilityDto
    {
        [Key]
        [JsonProperty("eligibilityId")]
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
