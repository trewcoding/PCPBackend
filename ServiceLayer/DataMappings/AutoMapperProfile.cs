using ApiClients.DTOS.Product;
using ApiClients.DTOS.Products;
using AutoMapper;
using Domain.Entities.Product;
using Domain.Entities.Products;
using ServiceLayer.DTOS.Product;
using ServiceLayer.DTOS.Products;

namespace ServiceLayer.DataMappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            AddDomainToServiceLayerMapping();
            AddApiClientToServiceLayerMapping();
        }

        public void AddDomainToServiceLayerMapping()
        {
            CreateMap<ProductAdditionalInformationSl, ProductAdditionalInformation>().ReverseMap();
            CreateMap<ProductDataSl, ProductData>().ReverseMap();
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
            CreateMap<ProductDataSl, ProductDataAc>().ReverseMap();
            CreateMap<ProductDiscountSl, ProductDiscountAc>().ReverseMap();
            CreateMap<ProductEligibilitySl, ProductEligibilityAc>().ReverseMap();
            CreateMap<ProductFeatureSl, ProductFeatureAc>().ReverseMap();
            CreateMap<ProductFeeSl, ProductFeeAc>().ReverseMap();
            CreateMap<ProductLendingRateSl, ProductLendingRateAc>();
            CreateMap<ProductResponseApiSl, ProductResponseApiAc>().ReverseMap();
            CreateMap<DataSl, DataAc>().ReverseMap();
            CreateMap<ProductsResponseApiSl, ProductsResponseApiAc>().ReverseMap();
            CreateMap<ProductsSl, ProductsAc>().ReverseMap();
        }
    }
}
