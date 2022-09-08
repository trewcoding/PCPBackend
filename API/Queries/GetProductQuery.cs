using Domain.Entities.ProductCommBank;
using MediatR;

namespace API.Queries
{
    public class GetProductQuery : IRequest<ProductResponseApi>
    {
        public string ProductId { get; set; }
        public string Bank { get; set; }

        public GetProductQuery(string productId, string bank)
        {
            ProductId = productId;
            Bank = bank;
        }
    }
}
