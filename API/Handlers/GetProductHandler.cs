using API.Queries;
using ApiClients.ProductsApiClient.IProductsApiClient;
using AutoMapper;
using DataAccess.Services;
using Domain.Entities.ProductCommBank;
using MediatR;
using static ApiClients.Extensions.Enums;

namespace API.Handlers
{
    public class GetProductHandler : IRequestHandler<GetProductQuery, ProductResponseApi>
    {
        private IProducts _products;
        private IDataAccessLayer _dataAccessLayer;
        private IMapper _mapper;

        public GetProductHandler(IProducts products, IDataAccessLayer dataAccessLayer, IMapper mapper)
        {
            _products = products;
            _dataAccessLayer = dataAccessLayer;
            _mapper = mapper;
        }

        public async Task<ProductResponseApi> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var result = await _products.GetProduct(request.ProductId, request.Bank);
            await _dataAccessLayer.SaveProduct(result.Data);
            return result;
        }
    }
}
