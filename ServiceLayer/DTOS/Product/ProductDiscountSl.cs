using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ServiceLayer.DTOS.Product
{
    public class ProductDiscountSl
    {
        public Guid DiscountId { get; set; }
        public Guid ProductFeeEfFeeId { get; set; }
        public string Description { get; set; }
        public string DiscountType { get; set; }
        public string Amount { get; set; }
        public List<ProductEligibilitySl> Eligibility { get; set; }
    }
}
