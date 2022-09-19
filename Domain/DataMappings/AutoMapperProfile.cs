using AutoMapper;
using DataAccess.EfModels.Product;
using DataAccess.EfModels.Products;
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
            CreateMap<ProductAdditionalInformationEf, ProductAdditionalInformation>().ReverseMap();
            CreateMap<ProductDataEf, ProductData>().ReverseMap();
            CreateMap<ProductConstraintEf, ProductConstraint>().ReverseMap();
            CreateMap<ProductDiscountEf, ProductDiscount>().ReverseMap();
            CreateMap<ProductEligibilityEf, ProductEligibility>().ReverseMap();
            CreateMap<ProductFeatureEf, ProductFeature>().ReverseMap();
            CreateMap<ProductFeeEf, ProductFee>().ReverseMap();
            CreateMap<ProductLendingRateEf, ProductLendingRate>().ReverseMap();
            CreateMap<ProductResponseApiEf, ProductResponseApi>().ReverseMap();
            CreateMap<DataEf, Data>().ReverseMap();
            CreateMap<ProductsEf, Products>().ReverseMap();
            CreateMap<ProductsResponseApiEf, ProductsResponseApi>().ReverseMap();
        }
    }
}
