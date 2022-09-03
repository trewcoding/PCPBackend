using AutoMapper;
using DataAccess.EfModels.ProductCommBank;
using DataAccess.EfModels.ProductsCommBank;
using Domain.Entities.ProductCommBank;
using Domain.Entities.ProductsCommBank;

namespace Domain.ProductMappings
{
    public class ProductMappings : Profile
    {
        public ProductMappings()
        {
            CreateMap<ProductsEF, Products>().ReverseMap();
            CreateMap<ProductsResponseApiEF, ProductsResponseApi>().ReverseMap();
            CreateMap<DataEF, Data>().ReverseMap();
            CreateMap<AdditionalInformationEF, AdditionalInformation>().ReverseMap();

            CreateMap<ProductResponseApiEf, ProductResponseApi>().ReverseMap();
            CreateMap<ProductAdditionalInformationEf, ProductAdditionalInformation>().ReverseMap();
            CreateMap<ProductConstraintEf, ProductConstraint>().ReverseMap();
            CreateMap<ProductDataEfs, ProductData>().ReverseMap();
            CreateMap<ProductDiscountEf, ProductDiscount>().ReverseMap();
            CreateMap<ProductEligibilityEf, ProductEligibility>().ReverseMap();
            CreateMap<ProductFeatureEf, ProductFeature>().ReverseMap();
            CreateMap<ProductFeeEf, ProductFee>().ReverseMap();
            CreateMap<ProductLendingRateEf, ProductLendingRate>().ReverseMap();
        }
    }
}
