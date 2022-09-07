using DataAccess.Context;
using DataAccess.EfModels.ProductsCommBank;
using Domain.Entities.ProductsCommBank;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ApiClients.Activities
{
    public class List
    {
        public class Query : IRequest<List<Products>> {}

        public class Handler : IRequestHandler<Query, List<Products>>
        {
            private readonly ApplicationDbContext _dbContext;

            public Handler(ApplicationDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<List<Products>> Handle(Query request, CancellationToken cancellationToken)
            {
                return null;//await _dbContext.ProductsDataSet.ToListAsync(cancellationToken);
            }
        }
    }
}
