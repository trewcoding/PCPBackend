using API.DTOS.ProductCommBank;
using API.DTOS.ProductsCommBank;
using AutoMapper;
using ServiceLayer.DTOS.ProductCommBank;
using ServiceLayer.DTOS.ProductsCommBank;

namespace API.DataMappings
{
    public class AutoMapperProfile : Profile
    {
        /// <summary>
        /// 
        /// </summary>
        public AutoMapperProfile()
        {
            AddAPItoServiceLayerMapping();
        }

        public void AddAPItoServiceLayerMapping()
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
