using Microsoft.AspNetCore.Mvc;
using DataAccess.Services;
using ServiceLayer;
using ApiClients.ProductsApiClient.IProductsApiClient;
using API.Queries;
using DataAccess.EfModels.ProductCommBank;
using MediatR;
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
        private readonly IMediator _mediator;

        public ProductsController(IProducts products, IDataAccessLayer dataAccessLayer, IProductDetailsGetter productDetailsGetter, IMediator mediator)
        {
            _products = products;
            _dataAccessLayer = dataAccessLayer;
            _productDetailsGetter = productDetailsGetter;
            _mediator = mediator;
        }

        [HttpGet("apiCall", Name = "GetProducts")]
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

        [HttpGet("apiCall/{productId}", Name = "Get one Product")]
        public async Task<IActionResult> GetProductCall(string productId, string bank)
        {
            var result = await _products.GetProduct(productId, bank);
            await _dataAccessLayer.SaveProduct(result.Data);
            return Ok(result);
        }

        [HttpGet(Name = "List of All Products")]
        public async Task<ActionResult<List<ProductDataEf>>> GetAllProducts()
        {
            return Ok(await _mediator.Send(new QueryListAllProducts()));
        }

        [HttpGet("{productId}", Name = "GetProductField")]
        public async Task<ActionResult<ProductDataEf>> GetProduct(string productId)
        {
            return Ok(await _mediator.Send(new QueryProductDetails { ProductId = productId }));
        }


    }
}
