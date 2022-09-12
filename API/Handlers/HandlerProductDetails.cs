using API.Queries;
using AutoMapper;
using DataAccess.DTOS.ProductCommBank;
using DataAccess.Services;
using MediatR;

namespace API.Handlers
{
    public class HandlerProductDetails : IRequestHandler<QueryProductDetails, ProductDataDto>
    {
        private readonly IDataAccessLayer _dataAccessLayer;
        private readonly IMapper _mapper;

        public HandlerProductDetails(IDataAccessLayer dataAccessLayer, IMapper mapper)
        {

            _dataAccessLayer = dataAccessLayer;
            _mapper = mapper;
        }

        public async Task<ProductDataDto> Handle(QueryProductDetails request, CancellationToken cancellationToken)
        {
            var items = await _dataAccessLayer.GetProductDetails(productId: request.ProductId);
            //var results = _mapper.Map<ProductDataDto>(items);
            return items;
        }
    }
}
