using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using static ApiClients.Extensions.Enums;
using ApiClients.ProductsApiClient;
using DataAccess.Services;
using API.Queries;
using MediatR;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        private readonly IProducts _products;
        private readonly IDataAccessLayer _dataAccessLayer;
        private readonly IProductsServices _productDetailsGetter;
        private readonly IMediator _mediator;
        public ProductsController(IProducts products, IDataAccessLayer dataAccessLayer, IProductsServices productDetailsGetter, IMediator mediator)
        {
            _products = products;
            _dataAccessLayer = dataAccessLayer;
            _productDetailsGetter = productDetailsGetter;
            _mediator = mediator;
        }

        [HttpGet(Name = "GetProducts")]
        public async Task<IActionResult> GetProductsCall()
        {
            List<string> banks = Enum.GetValues<Banks>().Cast<string>().ToList();
            foreach (var bank in banks)
            {
                return Ok(await _mediator.Send(new QueryListAllProducts()));
                var result = await _products.GetProducts(bank.ToString());
                //await _productDetailsGetter.GetProductDetailsAsync(result.Data.Products, bank.ToString());
                await _dataAccessLayer.SaveProducts(result.Data.Products);
                
            }
            return Ok();
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProductCall(string productId, string bank)
        {
            return Ok(await _mediator.Send(new QueryProductDetails(productId, bank)));
        }


    }
}
