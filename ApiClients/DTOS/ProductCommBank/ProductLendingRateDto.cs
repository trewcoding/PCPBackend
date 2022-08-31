using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClients.DTOS.ProductCommBank
{
    public class ProductLendingRateDto
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
