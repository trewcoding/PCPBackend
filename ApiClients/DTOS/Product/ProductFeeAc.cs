using Newtonsoft.Json;

namespace ApiClients.DTOS.Product
{
    public class ProductFeeAc
    {
        public Guid FeeId { get; set; }
        [JsonProperty("productDataEfProductId")]
        public string ProductDataEfProductId { get; set; }
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
        public List<ProductDiscountAc> Discounts { get; set; }

        [JsonProperty("transactionRate")]
        public string TransactionRate { get; set; }
    }
}
