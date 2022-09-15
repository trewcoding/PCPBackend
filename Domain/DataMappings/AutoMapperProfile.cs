using AutoMapper;
using Domain.Entities.Product;
using Domain.Entities.Products;

namespace Domain.DataMappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            AddDomainToDomainMappings();
        }

        /// <summary>
        /// Adds the Product Mappings AutoMapperProfile
        /// </summary>
        public void AddDomainToDomainMappings()
        {
            CreateMap<ProductAdditionalInformation, ProductAdditionalInformation>().ReverseMap();
            CreateMap<ProductData, ProductData>().ReverseMap();
            CreateMap<ProductConstraint, ProductConstraint>().ReverseMap();
            CreateMap<ProductDiscount, ProductDiscount>().ReverseMap();
            CreateMap<ProductEligibility, ProductEligibility>().ReverseMap();
            CreateMap<ProductFeature, ProductFeature>().ReverseMap();
            CreateMap<ProductFee, ProductFee>().ReverseMap();
            CreateMap<ProductLendingRate, ProductLendingRate>().ReverseMap();
            CreateMap<ProductResponseApi, ProductResponseApi>().ReverseMap();
            CreateMap<Data, Data>().ReverseMap();
            CreateMap<Products, Products>().ReverseMap();
            CreateMap<ProductsResponseApi, ProductsResponseApi>().ReverseMap();
        }
    }
}
