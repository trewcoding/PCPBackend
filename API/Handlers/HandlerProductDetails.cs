
using API.DTOS.Product;
using API.Queries;
using AutoMapper;
using MediatR;
using ServiceLayer.DetailsService;


namespace API.Handlers
{
    public class HandlerProductDetails : IRequestHandler<QueryProductDetails, ProductDataApi>
    {
        private readonly IMapper _mapper;
        private readonly IProductService _serviceLayer;

        public HandlerProductDetails(IMapper mapper, IProductService serviceLayer)
        {
            _mapper = mapper;
            _serviceLayer = serviceLayer;

        }

        public async Task<ProductDataApi> Handle(QueryProductDetails request, CancellationToken cancellationToken)
        {
            var productServiceDetailResponse = await _serviceLayer.GetProductDetails(request.ProductId);
            var result = _mapper.Map<ProductDataApi>(productServiceDetailResponse);
            return result;
        }
    }
}
