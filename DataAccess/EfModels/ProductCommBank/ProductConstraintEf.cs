using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.EfModels.ProductCommBank
{
    public class ProductConstraintEf
    {
        public Guid ConstraintId { get; set; } = Guid.NewGuid();
        public string ProductDataEfProductId { get; set; }
        [JsonProperty("constraintType")]
        public string ConstraintType { get; set; }

        [JsonProperty("additionalValue")]
        public string AdditionalValue { get; set; }

        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
    }
}
