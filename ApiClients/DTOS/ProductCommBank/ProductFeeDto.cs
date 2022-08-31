using Newtonsoft.Json;

namespace ApiClients.DTOS.ProductCommBank
{
    public class ProductFeeDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("feeType")]
        public string FeeType { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }

        [JsonProperty("additionalValue")]
        public string AdditionalValue { get; set; }

        [JsonProperty("discounts")]
        public List<ProductDiscountDto> Discounts { get; set; }

        [JsonProperty("transactionRate")]
        public string TransactionRate { get; set; }
    }
}
