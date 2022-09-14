
﻿using API.DTOS.ProductCommBank;
using API.Queries;
using AutoMapper;
using DataAccess.Services;
using MediatR;
using ServiceLayer;
using System.Reflection.Metadata.Ecma335;


namespace API.Handlers
{
    public class HandlerProductDetails : IRequestHandler<QueryProductDetails, ProductDataDto>
    {
        private readonly IMapper _mapper;
        private readonly IProductsServices _serviceLayer;

        public HandlerProductDetails(IMapper mapper, IProductsServices serviceLayer)
        {
            _mapper = mapper;
            _serviceLayer = serviceLayer;

        }

        public async Task<ProductDataDto> Handle(QueryProductDetails request, CancellationToken cancellationToken)
        {
            var productServiceDetailResponse = await _serviceLayer.GetProductAsync(request.ProductId, request.Bank);
            var result = _mapper.Map<ProductDataDto>(productServiceDetailResponse.Data);
            return result;
        }
    }
}
