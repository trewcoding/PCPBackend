using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using DataAccess.Context;
using API.Queries;
using API.DTOS.Products;

namespace API.Handlers
{
    public class HandlerListAllProducts : IRequestHandler<QueryListAllProducts, List<ProductsApi>>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public HandlerListAllProducts(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<ProductsApi>> Handle(QueryListAllProducts request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.ProductsDataSet.ToListAsync();
            var resultDto = _mapper.Map<List<ProductsApi>>(result);
            return resultDto;
        }
    }
}
