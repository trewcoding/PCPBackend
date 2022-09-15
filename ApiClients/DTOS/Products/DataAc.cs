using Newtonsoft.Json;

namespace ApiClients.DTOS.Products
{
    public class DataAc
    {
        [JsonProperty("products")]
        public List<ProductsAc> Products { get; set; }
    }
}
