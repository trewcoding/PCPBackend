using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClients.DTOS.ProductCommBank
{
   public class ProductConstraintDto
    {
        [JsonProperty("constraintType")]
        public string ConstraintType { get; set; }

        [JsonProperty("additionalValue")]
        public string AdditionalValue { get; set; }

        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
    }
}
