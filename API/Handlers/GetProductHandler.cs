using API.Queries;
using Domain.Entities.ProductCommBank;
using MediatR;

namespace API.Handlers
{
    public class GetProductHandler : IRequestHandler<GetProductQuery, ProductResponseApi>
    {
        public async Task<ProductResponseApi> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            
        }
    }
}
