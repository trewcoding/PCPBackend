using Newtonsoft.Json;

namespace API.DTOS.ProductCommBank
{
    public class ProductResponseApiDto
    {
        [JsonProperty("data")]
        public ProductDataDto? Data { get; set; }
    }


}
