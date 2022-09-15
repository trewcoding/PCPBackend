using Newtonsoft.Json;

namespace API.DTOS.Product
{
    public class ProductDiscountApi
    {
        [JsonProperty("discountId")]
        public Guid DiscountId { get; set; }
        [JsonProperty("productFeeEfProductId")]
        public string ProductFeeEfProductId { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discountType")]
        public string DiscountType { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("eligibility")]
        public List<ProductEligibilityApi> Eligibility { get; set; }
    }
}
