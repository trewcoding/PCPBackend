using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ServiceLayer.DTOS.Product
{
    public class ProductEligibilitySl
    {
        public Guid EligibilityId { get; set; }
        public string ProductDataEfProductId { get; set; }
        public string EligibilityType { get; set; }
        public string AdditionalValue { get; set; }
        public string AdditionalInfo { get; set; }
        public string DiscountEligibilityType { get; set; }
    }
}
