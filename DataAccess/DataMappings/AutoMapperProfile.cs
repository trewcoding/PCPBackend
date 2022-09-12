using AutoMapper;
using DataAccess.EfModels.ProductCommBank;
using DataAccess.EfModels.ProductsCommBank;
using Domain.Entities.ProductCommBank;
using Domain.Entities.ProductsCommBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            CreateMap<AdditionalInformationEF, AdditionalInformation>().ReverseMap();
            CreateMap<DataEF, Data>().ReverseMap();
            CreateMap<ProductsEF, Products>().ReverseMap();
            CreateMap<ProductsResponseApiEF, ProductsResponseApi>().ReverseMap();
        }
    }
}
