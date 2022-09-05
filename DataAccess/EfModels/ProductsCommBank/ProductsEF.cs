using Newtonsoft.Json;

namespace DataAccess.EfModels.ProductsCommBank
{
    public class ProductsEF
    {
        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("lastUpdated")]
        public DateTime LastUpdated { get; set; }
    }
}
