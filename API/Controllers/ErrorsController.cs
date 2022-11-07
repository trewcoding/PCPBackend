using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using static ApiClients.Extensions.Enums;
using DataAccess.Services;
using API.Queries;
using MediatR;
using ServiceLayer.DetailsService;
using DataAccess.EfModels.Product;
using API.DTOS.Product;
using Microsoft.AspNetCore.Diagnostics;

namespace API.Controllers
{
    [ApiController]
    [Route("error")]
    [Produces("application/problem+json")]
    public class ErrorsController : ControllerBase
    {
        private readonly ILogger<ErrorsController> _logger;

        public ErrorsController(ILogger<ErrorsController> _logger)
        {
            this._logger = _logger;
        }

        //[HttpGet("")]
        //public async Task<IActionResult> Error()
        //{
        //    Exception exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
        //    return await GeneralExceptionHandler(exception);
        //}

        //private Task<IActionResult> GeneralExceptionHandler(Exception? exception)
        //{
        //    var error = exception as Exception;
        //    _logger.LogError($"Invalid Request:: {error.Message}");
        //}
    }
}
