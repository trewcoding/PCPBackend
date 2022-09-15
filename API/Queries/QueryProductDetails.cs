using API.DTOS.Product;
using MediatR;

namespace API.Queries
{
    public class QueryProductDetails : IRequest<ProductDataApi>
    {
        public string ProductId { get; }
        public string Bank { get; }
        public QueryProductDetails(string productId, string bank)
        {
            ProductId = productId;
            Bank = bank;
        }
    }
}
