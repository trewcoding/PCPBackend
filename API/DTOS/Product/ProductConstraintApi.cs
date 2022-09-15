using Newtonsoft.Json;

namespace API.DTOS.Product
{
    public class ProductConstraintApi
    {
        public Guid ConstraintId { get; set; }
        [JsonProperty("productDataEfProductId")]
        public string ProductDataEfProductId { get; set; }
        [JsonProperty("constraintType")]
        public string? ConstraintType { get; set; }

        [JsonProperty("additionalValue")]
        public string? AdditionalValue { get; set; }

        [JsonProperty("additionalInfo")]
        public string? AdditionalInfo { get; set; }
    }
}
