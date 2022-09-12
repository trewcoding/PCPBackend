using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ServiceLayer.DTOS.ProductCommBank
{
    public class ProductDiscountSL
    {
        [Key]
        [JsonProperty("discountId")]
        public Guid DiscountId { get; set; }
        [JsonProperty("productFeeEfProductId")]
        public string ProductFeeEfProductId { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discountType")]
        public string DiscountType { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("eligibility")]
        public List<ProductEligibilitySL> Eligibility { get; set; }
    }
}
