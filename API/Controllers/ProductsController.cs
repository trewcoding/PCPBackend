
using DataAccess.EfModels.ProductsCommBank;
using Microsoft.AspNetCore.Mvc;
using DataAccess.Services;
using ApiClients.CommBankApiClient.ProductsApiClient.IProductsApiClient;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        private readonly IProducts _products;
        private readonly IDataAccessLayer _dataAccessLayer;
        private readonly ProductController _productController;

        public ProductsController(IProducts products, IDataAccessLayer dataAccessLayer, ProductController productController)
        {

            _products = products;
            _dataAccessLayer = dataAccessLayer;
            _productController = productController;
        }

        [HttpGet(Name = "GetProducts")]
        public async Task<IActionResult> GetProductsCall()
        {
            var result = await _products.GetProducts();
            await _dataAccessLayer.SaveProducts(result.Data.Products);
            return Ok(result);
        }
        
        
    }
}
