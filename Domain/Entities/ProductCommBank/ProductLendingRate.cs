using Newtonsoft.Json;

namespace Domain.Entities.ProductCommBank
{
    public class ProductLendingRate
    {
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
