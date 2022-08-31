using Newtonsoft.Json;

namespace DataAccess.EfModels.ProductsCommBank
{
    public class AdditionalInformationEF
    {
        [JsonProperty("overviewUri")]
        public string OverviewUri { get; set; }

        [JsonProperty("termsUri")]
        public string TermsUri { get; set; }

        [JsonProperty("eligibilityUri")]
        public string EligibilityUri { get; set; }

        [JsonProperty("feesAndPricingUri")]
        public string FeesAndPricingUri { get; set; }
        [JsonProperty("productId")]
        public string ProductId { get; set; }
    }
}
