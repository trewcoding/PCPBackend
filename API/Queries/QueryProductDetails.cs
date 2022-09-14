
﻿using API.DTOS.ProductCommBank;
 
using MediatR;

namespace API.Queries
{
    public class QueryProductDetails : IRequest<ProductDataDto>
    {
        public string ProductId { get; }
        public string Bank { get; }
        public QueryProductDetails(string productId, string bank)
        {
            ProductId = productId;
            Bank = bank;
        }
    }
}
