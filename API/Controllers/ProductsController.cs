using Microsoft.AspNetCore.Mvc;
using DataAccess.Services;
using ServiceLayer;
using ApiClients.ProductsApiClient.IProductsApiClient;
using static ApiClients.Extensions.Enums;
using MediatR;
using API.Queries;

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
            var query = new GetProductQuery(productId, bank);
            var result = await _mediator.Send(query);
            return Ok(result);
        }


    }
}
