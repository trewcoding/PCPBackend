using Newtonsoft.Json;

namespace ApiClients.DTOS.Product
{
    public class ProductResponseApiAc
    {
        [JsonProperty("data")]
        public ProductDataAc Data { get; set; }
    }
}
