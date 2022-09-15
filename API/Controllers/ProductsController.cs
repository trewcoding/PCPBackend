using Microsoft.AspNetCore.Mvc;
using static ApiClients.Extensions.Enums;
using ApiClients.ProductsApiClient;
using DataAccess.Services;
using API.Queries;
using MediatR;
using ServiceLayer.DetailsService;
using DataAccess.EfModels.Product;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        private readonly IDataAccessLayer _dataAccessLayer;
        private readonly IMediator _mediator;
        private readonly IProductService _productService;

        public ProductsController(IDataAccessLayer dataAccessLayer, IMediator mediator, IProductService productService)
        {
            _dataAccessLayer = dataAccessLayer;
            _mediator = mediator;
            _productService = productService;
        }

        [HttpGet("apiCall", Name = "GetProducts")]
        public async Task<IActionResult> GetProductsCall()
        {
            List<string> banks = Enum.GetValues<Banks>().Cast<string>().ToList();
            foreach (var bank in banks)
            {
                var result = await _productService.GetProductsExternalCall(bank.ToString());
                return Ok(result);
                //await _productDetailsGetter.GetProductDetailsAsync(result.Data.Products, bank.ToString());
                //await _dataAccessLayer.SaveProducts(result.Data.Products);`````   
                //return Ok(await _mediator.Send(new QueryListAllProducts()));
            }
            return Ok();
        }

        //[HttpGet("apiCall/{productId}", Name = "Get one Product")]
        //public async Task<IActionResult> GetProductCall(string productId, string bank)
        //{
        //    return Ok(await _mediator.Send(new QueryProductDetails(productId, bank)));
        //}

        //[HttpGet(Name = "List of All Products")]
        //public async Task<ActionResult<List<ProductDataEf>>> GetAllProducts()
        //{
        //    return Ok(await _mediator.Send(new QueryListAllProducts()));
        //}

        //[HttpGet("{productId}", Name = "GetProductField")]
        //public async Task<ActionResult<ProductDataEf>> GetProduct(string productId)
        //{
        //    return Ok(await _mediator.Send(new QueryProductDetails { ProductId = productId }));
        //}


    }
}
