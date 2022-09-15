using API.DTOS.Products;
using MediatR;

namespace API.Queries
{
    public class QueryListAllProducts : IRequest<List<ProductsApi>>
    {
    }
}
