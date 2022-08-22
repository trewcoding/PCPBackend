using AutoMapper;
using DataAccess.EfModels;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ProductMappings
{
    public class ProductMappings : Profile
    {
        public ProductMappings()
        {
            CreateMap<ProductEF, Product>().ReverseMap();
            CreateMap<ProductResponseApiEF, ProductResponseApi>().ReverseMap();
            CreateMap<DataEF, Data>().ReverseMap();
            CreateMap<AdditionalInformationEF, AdditionalInformation>().ReverseMap();
        }
    }
}
