using Microsoft.AspNetCore.Mvc;
using Domain.Entities.ProductsCommBank;
using ApiClients.Activities;
using DataAccess.EfModels.ProductsCommBank;

namespace API.Controllers
{
    public class WebApiController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Products>>> GetAllProducts()
        {
            return await Mediator.Send(new List.Query());

        }
    }
}
