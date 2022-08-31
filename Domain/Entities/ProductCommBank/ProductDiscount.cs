using Newtonsoft.Json;


namespace Domain.Entities.ProductCommBank
{
    public class ProductDiscount
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discountType")]
        public string DiscountType { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("eligibility")]
        public List<ProductEligibility> Eligibility { get; set; }
    }
}
