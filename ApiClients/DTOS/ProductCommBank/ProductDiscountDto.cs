using Newtonsoft.Json;


namespace ApiClients.DTOS.ProductCommBank
{
    public class ProductDiscountDto
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discountType")]
        public string DiscountType { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("eligibility")]
        public List<ProductEligibilityDto> Eligibility { get; set; }
    }
}
