using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ApiCients.DTOS.ProductCommBank
{
    public class ProductLendingRateDto
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
