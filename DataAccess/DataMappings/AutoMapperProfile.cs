using AutoMapper;
using DataAccess.EfModels.Product;
using DataAccess.EfModels.Products;
using Domain.Entities.Product;
using Domain.Entities.Products;

namespace DataAccess.DataMappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            AddProductMappings();
            AddProductsMappings();
        }

        /// <summary>
        /// Adds the Product Mappings AutoMapperProfile
        /// </summary>
        public void AddProductMappings()
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
        }
        /// <summary>
        /// Adds the Products Mappings AutoMapperProfile
        /// </summary>
        public void AddProductsMappings()
        {
            CreateMap<DataEf, Data>().ReverseMap();
            CreateMap<Products, ProductsEf>().ReverseMap();
            CreateMap<ProductsResponseApiEf, ProductsResponseApi>().ReverseMap();
        }
    }
}
