using Newtonsoft.Json;


namespace DataAccess.EfModels.ProductCommBank
{
    public class ProductDiscountEf
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discountType")]
        public string DiscountType { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("eligibility")]
        public List<ProductEligibilityEf> Eligibility { get; set; }
    }
}
