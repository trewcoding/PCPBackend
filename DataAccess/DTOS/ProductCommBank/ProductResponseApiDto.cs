using Newtonsoft.Json;

namespace DataAccess.DTOS.ProductCommBank
{
    public class ProductResponseApiDto
    {
        [JsonProperty("data")]
        public ProductDataDto Data { get; set; }
    }


}
