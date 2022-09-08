using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.DTOS.ProductCommBank
{
    public class ProductLendingRateDto
    {
        [Key]
        public Guid LendingRatesId { get; set; }
        public string ProductDataEfProductId { get; set; }
        //[JsonProperty("lendingRateType")]
        public string LendingRateType { get; set; }

        //[JsonProperty("rate")]
        public string Rate { get; set; }

        //[JsonProperty("calculationFrequency")]
        public string CalculationFrequency { get; set; }

        //[JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
    }
}
