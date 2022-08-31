
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

        public ProductsController(IProducts products, IDataAccessLayer dataAccessLayer)
        {

            _products = products;
            _dataAccessLayer = dataAccessLayer;
        }

        [HttpGet(Name = "GetProducts")]
        public async Task<IActionResult> GetProductsCall()
        {
            var result = await _products.GetProducts();
             await  _dataAccessLayer.SaveProducts(result.Data.Products);
            return Ok(result);
        }
        
        
    }
}
