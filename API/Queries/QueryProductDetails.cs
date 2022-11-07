using API.DTOS.Product;
using MediatR;

namespace API.Queries
{
    public class QueryProductDetails : IRequest<ProductDataApi>
    {
        public string ProductId { get; }
        public QueryProductDetails(string productId)
        {
            ProductId = productId;
        }
    }
}
