using Newtonsoft.Json;

namespace ApiClients.DTOS.Product
{
    public class ProductDiscountAc
    {
        [JsonProperty("discountId")]
        public Guid DiscountId { get; set; }
        public Guid ProductFeeEfFeeId { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discountType")]
        public string DiscountType { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("eligibility")]
        public List<ProductEligibilityAc> Eligibility { get; set; }
    }
}
