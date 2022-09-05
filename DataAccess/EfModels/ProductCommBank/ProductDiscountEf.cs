using Newtonsoft.Json;


namespace DataAccess.EfModels.ProductCommBank
{
    public class ProductDiscountEf
    {
        public Guid DiscountId { get; set; } = Guid.NewGuid();
        //public string ProductDataEfProductId { get; set; }
        public string ProductFeeEfProductId { get; set; }
        public Guid ProductFeeEfFeeId { get; set; }
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
