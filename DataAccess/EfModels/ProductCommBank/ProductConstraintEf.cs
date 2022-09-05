using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.EfModels.ProductCommBank
{
    public class ProductConstraintEf
    {
        [Key]
        public Guid ConstraintId { get; set; } = Guid.NewGuid();
        [JsonProperty("constraintType")]
        public string ConstraintType { get; set; }

        [JsonProperty("additionalValue")]
        public string AdditionalValue { get; set; }

        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
        public string ProductDataEfProductId { get; set; }
        //public ProductDataEf ProductDataEf { get; set; }
    }
}
