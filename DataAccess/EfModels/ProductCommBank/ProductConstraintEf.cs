using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.EfModels.ProductCommBank
{
    public class ProductConstraintEf
    {
        [Key]
        [JsonProperty("constrainId")]
        public Guid ConstraintId { get; set; } = Guid.NewGuid();
        [ForeignKey("productDataEfProductId")]
        [JsonProperty("productDataEfProductId")]
        public virtual string ProductDataEfProductId { get; set; }
        [JsonProperty("constraintType")]
        public string ConstraintType { get; set; }

        [JsonProperty("additionalValue")]
        public string AdditionalValue { get; set; }

        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
        public virtual ProductDataEf ProductDataEf { get; set; }
    }
}
