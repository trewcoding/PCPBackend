using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using DataAccess.Context;
using API.Queries;
using API.DTOS.Products;
using ServiceLayer.DetailsService;

namespace API.Handlers
{
    public class HandlerListAllProducts : IRequestHandler<QueryListAllProducts, List<ProductsApi>>
    {
        private readonly IMapper _mapper;
        private readonly IProductService _serviceLayer;

        public HandlerListAllProducts(IMapper mapper, IProductService serviceLayer)
        {
            _mapper = mapper;
            _serviceLayer = serviceLayer;

        }

        public async Task<List<ProductsApi>> Handle(QueryListAllProducts request, CancellationToken cancellationToken)
        {
            var result = await _serviceLayer.GetAllProducts();
            var resultDto = _mapper.Map<List<ProductsApi>>(result);
            return resultDto;
        }
    }
}
