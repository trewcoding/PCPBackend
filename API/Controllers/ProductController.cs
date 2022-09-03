using ApiClients.CommBankApiClient.ProductApitClient;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _product;
        private readonly IDataAccessLayer _dataAccessLayer;

        public ProductController(IProduct product, IDataAccessLayer dataAccessLayer)
        {
            _product = product;
            _dataAccessLayer = dataAccessLayer;
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProductCall(string productId)
        {
            var result = await _product.GetProduct(productId);
            await _dataAccessLayer.SaveProduct(result.Data);
            //await _dataAccessLayer.SaveProductFeature(result.Data.Features);
            //await _dataAccessLayer.SaveProductConstraint(result.Data.Constraints);

            return Ok(result);
        }
    }
}
