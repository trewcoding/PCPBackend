using Newtonsoft.Json;

namespace DataAccess.EfModels.ProductCommBank
{
    public class ProductResponseApiEf
    {
        [JsonProperty("data")]
        public ProductDataEfs Data { get; set; }
    }
}
