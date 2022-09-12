using ApiClients.DTOS.ProductsCommBank;
using AutoMapper;
using ApiCients.DTOS.ProductCommBank;
using Domain.Entities.ProductCommBank;
using Domain.Entities.ProductsCommBank;
using DataAccess.EfModels.ProductCommBank;
using DataAccess.EfModels.ProductsCommBank;

namespace API.ProductMappings
{
    public class ProductMappings : Profile
    {
        public ProductMappings()
        {
            CreateMap<ProductsEF, Products>().ReverseMap();
            CreateMap<ProductDataEf, ProductDataDto>().ReverseMap();
            CreateMap<ProductsEF, ProductsDto>().ReverseMap();
            CreateMap<ProductsResponseApiEF, ProductsResponseApi>().ReverseMap();
            CreateMap<DataEF, Data>().ReverseMap();
            CreateMap<AdditionalInformationEF, AdditionalInformation>().ReverseMap();

            CreateMap<ProductResponseApiEf, ProductResponseApi>().ReverseMap();
            CreateMap<ProductAdditionalInformationEf, ProductAdditionalInformation>().ReverseMap();
            CreateMap<ProductConstraintEf, ProductConstraint>().ReverseMap();
            CreateMap<ProductDataEf, ProductData>().ReverseMap();
            CreateMap<ProductDiscountEf, ProductDiscount>().ReverseMap();
            CreateMap<ProductEligibilityEf, ProductEligibility>().ReverseMap();
            CreateMap<ProductFeatureEf, ProductFeature>().ReverseMap();
            CreateMap<ProductFeeEf, ProductFee>().ReverseMap();
            CreateMap<ProductLendingRateEf, ProductLendingRate>().ReverseMap();
        }
    }
}
