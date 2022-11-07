using Newtonsoft.Json;

namespace ApiClients.DTOS.Products
{
    public class ProductsResponseApiAc
    {
        [JsonProperty("data")]
        public DataAc Data { get; set; }

    }
}
