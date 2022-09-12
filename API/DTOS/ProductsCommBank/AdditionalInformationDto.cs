using Newtonsoft.Json;

namespace API.DTOS.ProductsCommBank
{
    public class AdditionalInformationDto
    {
        [JsonProperty("overviewUri")]
        public string? OverviewUri { get; set; }

        [JsonProperty("termsUri")]
        public string? TermsUri { get; set; }

        [JsonProperty("eligibilityUri")]
        public string? EligibilityUri { get; set; }

        [JsonProperty("feesAndPricingUri")]
        public string? FeesAndPricingUri { get; set; }
    }
}
