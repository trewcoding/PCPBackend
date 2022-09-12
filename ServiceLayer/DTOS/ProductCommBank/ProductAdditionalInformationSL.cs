using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ServiceLayer.DTOS.ProductCommBank
{
    public class ProductAdditionalInformationSL
    {
        [JsonProperty("additionalInformationId")]
        public Guid AdditionalInformationId { get; set; }
        [JsonProperty("productDataEfProductId")]
        public string ProductDataEfProductId { get; set; }
        [JsonProperty("overviewUri")]
        public string OverviewUri { get; set; }

        [JsonProperty("termsUri")]
        public string TermsUri { get; set; }

        [JsonProperty("eligibilityUri")]
        public string EligibilityUri { get; set; }

        [JsonProperty("feesAndPricingUri")]
        public string FeesAndPricingUri { get; set; }
    }
}
