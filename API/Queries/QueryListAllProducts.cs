using ApiClients.DTOS.ProductsCommBank;
using MediatR;

namespace API.Queries
{
    public class QueryListAllProducts : IRequest<List<ProductsDto>>
    {
    }
}
