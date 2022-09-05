using Newtonsoft.Json;

namespace DataAccess.EfModels.ProductCommBank
{
    public class ProductLendingRateEf
    {
        public Guid LendingRatesId { get; set; } = Guid.NewGuid();
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
