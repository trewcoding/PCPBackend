using ApiClients.ProductsApiClient.IProductsApiClient;
using DataAccess.EfModels;
using Microsoft.AspNetCore.Mvc;
using DataAccess.Services;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        private readonly IProducts _products;
        public ProductsController(IProducts products)
        {
            _products = products;
        }

        [HttpGet(Name = "GetProducts")]
        public async Task<IActionResult> GetProductsCall()
        {
            var result = await _products.GetProducts();
            return Ok(result);
        }
        
        
    }
}
