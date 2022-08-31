using Newtonsoft.Json;

namespace Domain.Entities.ProductCommBank
{
    public class ProductResponseApi
    {
        [JsonProperty("data")]
        public ProductData Data { get; set; }
    }


}
