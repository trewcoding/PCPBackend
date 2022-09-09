using Newtonsoft.Json;

namespace DataAccess.EfModels.ProductsCommBank
{
    public class ProductsEF
    {
        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("lastUpdated")]
        public DateTime LastUpdated { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("brandName")]
        public string? BrandName { get; set; }
        [JsonProperty("productCategory")]
        public string ProductCategory { get; set; }
    }
}
