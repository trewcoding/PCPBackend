using ApiClients.DTOS.Product;
using ApiClients.DTOS.Products;
using AutoMapper;
using Domain.Entities.Product;
using Domain.Entities.Products;
using ServiceLayer.DTOS.Product;
using ServiceLayer.DTOS.Products;

namespace ServiceLayer.DataMappings
{
    public class AutoMapperSl : Profile
    {
        public AutoMapperSl()
        {
            AddDomainToServiceLayerMapping();
            AddApiClientToServiceLayerMapping();
        }

        public void AddDomainToServiceLayerMapping()
        {
            CreateMap<ProductAdditionalInformationSl, ProductAdditionalInformation>().ReverseMap();
            CreateMap<ProductDataSl, ProductData>().ReverseMap();
            CreateMap<ProductConstraintSl, ProductConstraint>().ReverseMap();
            CreateMap<ProductDiscountSl, ProductDiscount>().ReverseMap();
            CreateMap<ProductEligibilitySl, ProductEligibility>().ReverseMap();
            CreateMap<ProductFeatureSl, ProductFeature>().ReverseMap();
            CreateMap<ProductFeeSl, ProductFee>().ReverseMap();
            CreateMap<ProductLendingRateSl, ProductLendingRate>().ReverseMap();
            CreateMap<ProductResponseApiSl, ProductResponseApi>().ReverseMap();
            CreateMap<ProductAdditionalInformationSl, ProductAdditionalInformation>().ReverseMap();
            CreateMap<DataSl, Data>().ReverseMap();
            CreateMap<ProductsSl, Products>().ReverseMap();
            CreateMap<ProductsResponseApiSl, ProductsResponseApi>().ReverseMap();
        }

        public void AddApiClientToServiceLayerMapping()
        {
            CreateMap<ProductAdditionalInformationSl, ProductAdditionalInformationAc>().ReverseMap();
            CreateMap<ProductConstraintSl, ProductConstraintAc>().ReverseMap().ForMember(dest => dest.ConstraintType, opt => opt.NullSubstitute("Constraint type not provided"));
            CreateMap<ProductDataSl, ProductDataAc>().ReverseMap();
            CreateMap<ProductDiscountSl, ProductDiscountAc>().ReverseMap().ForMember(dest => dest.DiscountType, opt => opt.NullSubstitute("Discount type not provided")); ;
            CreateMap<ProductEligibilitySl, ProductEligibilityAc>().ReverseMap();
            CreateMap<ProductFeatureSl, ProductFeatureAc>().ReverseMap().ForMember(dest => dest.FeatureType, opt => opt.NullSubstitute("Feature type not provided")); ;
            CreateMap<ProductFeeSl, ProductFeeAc>().ReverseMap().ForMember(dest => dest.FeeType, opt => opt.NullSubstitute("Fee type not provided")); ;
            CreateMap<ProductLendingRateSl, ProductLendingRateAc>().ReverseMap().ForMember(dest => dest.LendingRateType, opt => opt.NullSubstitute("Lending rate type not provided")); ;
            CreateMap<ProductResponseApiAc, ProductResponseApiSl>().ReverseMap();
            CreateMap<DataSl, DataAc>().ReverseMap();
            CreateMap<ProductsResponseApiSl, ProductsResponseApiAc>().ReverseMap();
            CreateMap<ProductsSl, ProductsAc>().ReverseMap();
        }
    }
}
