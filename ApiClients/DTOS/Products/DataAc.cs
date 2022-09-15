using Newtonsoft.Json;

namespace ApiClients.DTOS.Products
{
    public class DataAc
    {
        [JsonProperty("products")]
        public List<ProductsResponseApiAc> Products { get; set; }
    }
}
