using ApiCients.DTOS.ProductCommBank;
using ApiClients.DTOS.ProductsCommBank;
using AutoMapper;
using Domain.Entities.ProductCommBank;
using Domain.Entities.ProductsCommBank;
using ServiceLayer.DTOS.ProductCommBank;
using ServiceLayer.DTOS.ProductsCommBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DataMappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            AddEntityToServiceLayerMapping();
            AddApiClientToServiceLayerMapping();
        }

        public void AddEntityToServiceLayerMapping()
        {
            CreateMap<ProductAdditionalInformationSL, ProductAdditionalInformation>().ReverseMap();
            CreateMap<ProductDataSL, ProductData>().ReverseMap();
            CreateMap<ProductDiscountSL, ProductDiscount>().ReverseMap();
            CreateMap<ProductEligibilitySL, ProductEligibility>().ReverseMap();
            CreateMap<ProductFeatureSL, ProductFeature>().ReverseMap();
            CreateMap<ProductFeeSL, ProductFee>().ReverseMap();
            CreateMap<ProductLendingRateSL, ProductLendingRate>().ReverseMap();
            CreateMap<ProductResponseApiSL, ProductResponseApi>().ReverseMap();
            CreateMap<AdditionalInformationSL, AdditionalInformation>().ReverseMap();
            CreateMap<DataSL, Data>().ReverseMap();
            CreateMap<ProductsSL, Products>().ReverseMap();
            CreateMap<ProductsResponseApiSL, ProductsResponseApi>().ReverseMap();
        }

        public void AddApiClientToServiceLayerMapping()
        {
            CreateMap<ProductAdditionalInformationSL, ProductAdditionalInformationDto>().ReverseMap();
            CreateMap<ProductDataSL, ProductDataDto>().ReverseMap();
            CreateMap<ProductDiscountSL, ProductDiscountDto>().ReverseMap();
            CreateMap<ProductEligibilitySL, ProductEligibilityDto>().ReverseMap();
            CreateMap<ProductFeatureSL, ProductFeatureDto>().ReverseMap();
            CreateMap<ProductFeeSL, ProductFeeDto>().ReverseMap();
            CreateMap<ProductLendingRateSL, ProductLendingRateDto>();
            CreateMap<ProductResponseApiSL, ProductResponseApiDto>().ReverseMap();
            CreateMap<AdditionalInformationSL, AdditionalInformationDto>().ReverseMap();
            CreateMap<DataSL, DataDto>().ReverseMap();
            CreateMap<ProductsResponseApiSL, ProductsResponseApiDto>().ReverseMap();
            CreateMap<ProductsSL, ProductsDto>().ReverseMap();
        }
    }
}
