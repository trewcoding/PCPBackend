using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.DTOS.ProductCommBank
{
    public class ProductDiscountDto
    {
        [Key]
        public Guid DiscountId { get; set; }
        public string ProductFeeEfProductId { get; set; }
        //[JsonProperty("description")]
        public string Description { get; set; }

        //[JsonProperty("discountType")]
        public string DiscountType { get; set; }

        //[JsonProperty("amount")]
        public string Amount { get; set; }

        //[JsonProperty("eligibility")]
        public List<ProductEligibilityDto> Eligibility { get; set; }
    }
}
