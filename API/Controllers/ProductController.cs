using ApiClients.CommBankApiClient.ProductApitClient;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _product;

        public ProductController(IProduct product)
        {
            _product = product;
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProductCall(string productId)
        {
            var result = await _product.GetProduct(productId);
            return Ok(result);
        }
    }
}
