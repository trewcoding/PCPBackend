using DataAccess.DTOS.ProductCommBank;
using MediatR;

namespace API.Queries
{
    public class QueryProductDetails : IRequest<ProductDataDto>
    {
        public string ProductId { get; set; }
    }
}
