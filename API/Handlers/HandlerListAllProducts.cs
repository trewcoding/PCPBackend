using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using DataAccess.Context;
using ApiClients.DTOS.ProductsCommBank;
using API.Queries;

namespace API.Handlers
{
    public class HandlerListAllProducts : IRequestHandler<QueryListAllProducts, List<ProductsDto>>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public HandlerListAllProducts(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<ProductsDto>> Handle(QueryListAllProducts request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.ProductsDataSet.ToListAsync();
            var resultDto = _mapper.Map<List<ProductsDto>>(result);
            return resultDto;
        }
    }

}
