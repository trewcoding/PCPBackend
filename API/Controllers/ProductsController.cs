using Microsoft.AspNetCore.Mvc;
using static ApiClients.Extensions.Enums;
using DataAccess.Services;
using API.Queries;
using MediatR;
using ServiceLayer.DetailsService;
using DataAccess.EfModels.Product;
using API.DTOS.Product;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IProductService _productService;

        public ProductsController(IMediator mediator, IProductService productService)
        {
            _mediator = mediator;
            _productService = productService;
        }

        [HttpGet("apiCall", Name = "GetProducts")]
        public async Task<IActionResult> GetProductsCall()
        {
            var banks = Enum.GetValues(typeof(Banks));
            foreach (var bank in banks)
            {
                var result = await _productService.SaveProductsExternalCall(bank.ToString());
                foreach (var product in result.Data.Products)
                {
                    await _productService.SaveProductAsync(product.ProductId, bank.ToString());
                } 
                
            }
            return Ok(await _mediator.Send(new QueryListAllProducts()));
        }

        [HttpGet(Name = "List of All Products")]
        public async Task<ActionResult<List<ProductDataEf>>> GetAllProducts()
        {
            return Ok(await _mediator.Send(new QueryListAllProducts())); 
        }

        [HttpGet("{productId}", Name = "GetProductField")]
        public async Task<ActionResult<ProductDataApi>> GetProduct(string productId)
        {
            Console.WriteLine("here"+productId);
            return Ok(await _mediator.Send(new QueryProductDetails(productId)));
        }


    }
}
