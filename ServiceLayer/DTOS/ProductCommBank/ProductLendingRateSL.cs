using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ServiceLayer.DTOS.ProductCommBank
{
    public class ProductLendingRateSL
    {
        [Key]
        [JsonProperty("lendingRatesId")]
        public Guid LendingRatesId { get; set; }
        [JsonProperty("productDataEfProductId")]
        public string ProductDataEfProductId { get; set; }
        [JsonProperty("lendingRateType")]
        public string LendingRateType { get; set; }

        [JsonProperty("rate")]
        public string Rate { get; set; }

        [JsonProperty("calculationFrequency")]
        public string CalculationFrequency { get; set; }

        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
    }
}
