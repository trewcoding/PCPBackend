using API.DTOS.Product;
using API.DTOS.Products;
using AutoMapper;
using ServiceLayer.DTOS.Product;
using ServiceLayer.DTOS.Products;

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
            CreateMap<ProductAdditionalInformationSl, ProductAdditionalInformationApi>().ReverseMap();
            CreateMap<ProductDataSl, ProductDataApi>().ReverseMap();
            CreateMap<ProductDiscountSl, ProductDiscountApi>().ReverseMap();
            CreateMap<ProductConstraintSl, ProductConstraintApi>().ReverseMap();
            CreateMap<ProductEligibilitySl, ProductEligibilityApi>().ReverseMap();
            CreateMap<ProductFeatureSl, ProductFeatureApi>().ReverseMap();
            CreateMap<ProductFeeSl, ProductFeeApi>().ReverseMap();
            CreateMap<ProductLendingRateSl, ProductLendingRateApi>();
            CreateMap<ProductResponseApiSl, ProductResponseApiApi>().ReverseMap();
            CreateMap<DataSl, DataApi>().ReverseMap();
            CreateMap<ProductsResponseApiSl, ProductsResponseApiApi>().ReverseMap();
            CreateMap<ProductsSl, ProductsApi>().ReverseMap();
        }
    }
}
