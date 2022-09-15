using Newtonsoft.Json;

namespace API.DTOS.Product
{
    public class ProductResponseApiApi
    {
        [JsonProperty("data")]
        public ProductDataApi Data { get; set; }
    }
}
