using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ServiceLayer.DTOS.Product
{
    public class ProductAdditionalInformationSl
    {
        public Guid AdditionalInformationId { get; set; }
        public string ProductDataEfProductId { get; set; }
        public string OverviewUri { get; set; }
        public string TermsUri { get; set; }
        public string EligibilityUri { get; set; }
        public string FeesAndPricingUri { get; set; }
    }
}
