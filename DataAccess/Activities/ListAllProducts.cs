using AutoMapper;
using DataAccess.Context;
using DataAccess.DTOS.ProductCommBank;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Activities
{

    //public class QueryListAllProducts : IRequest<List<ProductDataDto>> { }

    //    public class HandlerListAllProducts : IRequestHandler<QueryListAllProducts, List<ProductDataDto>>
    //    {
    //        private readonly ApplicationDbContext _dbContext;
    //        private readonly IMapper _mapper;

    //        public HandlerListAllProducts(ApplicationDbContext dbContext, IMapper mapper)
    //        {
    //            _dbContext = dbContext;
    //            _mapper = mapper;
    //        }

    //        public async Task<List<ProductDataDto>> Handle(QueryListAllProducts request, CancellationToken cancellationToken)
    //        {
    //        var result = await _dbContext.ProductDataSet.ToListAsync();
    //        var resultDto = _mapper.Map<List<ProductDataDto>>(result);
    //        return resultDto;
    //    }
    //}
    
}
