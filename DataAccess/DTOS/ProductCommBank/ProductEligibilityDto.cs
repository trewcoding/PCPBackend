using System.ComponentModel.DataAnnotations;

namespace DataAccess.DTOS.ProductCommBank
{
    public class ProductEligibilityDto
    {
        [Key]
        public Guid EligibilityId { get; set; }
        public string ProductDataEfProductId { get; set; }
        //[JsonProperty("eligibilityType")]
        public string EligibilityType { get; set; }

        //[JsonProperty("additionalValue")]
        public string AdditionalValue { get; set; }

        //[JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }

        //[JsonProperty("discountEligibilityType")]
        public string DiscountEligibilityType { get; set; }
    }
}
