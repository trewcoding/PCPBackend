using System.ComponentModel.DataAnnotations;

namespace DataAccess.DTOS.ProductCommBank
{
    public class ProductConstraintDto
    {
        [Key]
        public Guid ConstraintId { get; set; }
        public string ProductDataEfProductId { get; set; }
        //[JsonProperty("constraintType")]
        public string ConstraintType { get; set; }

        //[JsonProperty("additionalValue")]
        public string AdditionalValue { get; set; }

        //[JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
    }
}
