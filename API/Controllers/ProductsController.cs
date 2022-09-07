using Microsoft.AspNetCore.Mvc;
using DataAccess.Services;
using ServiceLayer;
using ApiClients.ProductsApiClient.IProductsApiClient;
using static ApiClients.Extensions.Enums;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        private readonly IProducts _products;
        private readonly IDataAccessLayer _dataAccessLayer;
        private readonly IProductDetailsGetter _productDetailsGetter;

        public ProductsController(IProducts products, IDataAccessLayer dataAccessLayer, IProductDetailsGetter productDetailsGetter)
        {
            _products = products;
            _dataAccessLayer = dataAccessLayer;
            _productDetailsGetter = productDetailsGetter;
        }

        [HttpGet(Name = "GetProducts")]
        public async Task<IActionResult> GetProductsCall()
        {
            var banklist = Enum.GetValues(typeof(Banks));
            foreach (var bank in banklist)
            {
                var result = await _products.GetProducts(bank.ToString());
                await _productDetailsGetter.GetProductDetailsAsync(result.Data.Products, bank.ToString());
                await _dataAccessLayer.SaveProducts(result.Data.Products);
                
            }
            return Ok();
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProductCall(string productId, string bank)
        {
            var result = await _products.GetProduct(productId, bank);
            await _dataAccessLayer.SaveProduct(result.Data);
            return Ok(result);
        }


    }
}
