using Microsoft.AspNetCore.Mvc;
using DataAccess.DTOS.ProductCommBank;
using DataAccess.Activities;
using DataAccess.EfModels.ProductCommBank;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WebApiController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<ProductDataEf>>> GetAllProducts()
        {
            return Ok(await Mediator.Send(new QueryListAllProducts()));
        }

        [HttpGet("{productId}", Name = "GetProductField")]
        public ActionResult<ProductDataDto> GetProduct(string productId)
        {
            return Ok(Mediator.Send(new QueryProductDetails { ProductId = productId }));
        }

    }
}
