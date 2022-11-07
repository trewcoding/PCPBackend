using AutoMapper;
using DataAccess.EfModels.Product;
using DataAccess.EfModels.Products;
using DataAccess.Services;
using Domain.Entities.Product;
using Domain.Entities.Products;
using Domain.Services;
using Domain.UnitTests.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UnitTests
{
    public class ProductsPassThroughTest
    {
        private ProductsPassThrough _sut;
        private readonly IMapper _mapper;
        private readonly IDataAccessLayer _dataAccessLayer;
        private readonly IStringProcessing _stringProcessing;

        public ProductsPassThroughTest()
        {
            _mapper = Substitute.For<IMapper>();
            _dataAccessLayer = Substitute.For<IDataAccessLayer>();
            _stringProcessing = Substitute.For<IStringProcessing>();
            _sut = new ProductsPassThrough(_mapper, _dataAccessLayer, _stringProcessing);
        }

        [Fact]
        public async Task Should_PassToStringReplace_ThenMapAndPassToDataAccess_SaveProductsPassThrough()
        {
            //Arrange
            var listProducts = MockDtoDataProducts.listProducts();
            var listProductsEf = MockDtoDataEf.listProductsEf();

            var listOfProductIds = new List<string>()
            {
                "ProductId1",
                "ProductId2"
            };

            _stringProcessing.StringReplaceProducts(listProducts).Returns(listProducts);
            _mapper.Map<DataEf>(listProducts.Data).Returns(listProductsEf.Data);
            _dataAccessLayer.SaveProducts(listProductsEf.Data).Returns(listOfProductIds);

            //Act
            var result = await _sut.SaveProductsPassThrough(listProducts);
            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<List<string>>();
        }
        [Fact]
        public async Task Should_MapThanPassToDataAccess_SaveProductPassThrough()
        {
            //Arrange
            var productData = MockDtoDataProduct.productData();
            var productDataEf = MockDtoDataEf.productDataEf();  

            _stringProcessing.StringReplaceProduct(productData).Returns(productData);
            _mapper.Map<ProductDataEf>(productData).Returns(productDataEf);
            await _dataAccessLayer.SaveProduct(productDataEf);
            //Act
            var result = _sut.SaveProductPassThrough(productData);
            //Assert
            result.Should().NotBeNull();
        }
        [Fact]
        public async Task Should_RecieveProductDetails_MapAndPassToServiceLayer_GetProductDetailsPassThrough()
        {
            //Arrange
            var productData = MockDtoDataProduct.productData();
            var productDataEf = MockDtoDataEf.productDataEf();

            var productId = "ProductId1";

            _dataAccessLayer.GetProductDetails(productId).Returns(productDataEf);
            _mapper.Map<ProductData>(productDataEf).Returns(productData);
            //Act
            var result = await _sut.GetProductDetailsPassThrough(productId);
            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<ProductData>();
        }
        [Fact]
        public async Task Should_MapAndPassProductListToServiceLayer_GetAllProductsPassThough()
        {
            //Arrange
            var getListProducts = MockDtoDataProducts.getListProducts();
            var getListProductsEf = MockDtoDataEf.getListProductsEf();

            _dataAccessLayer.GetAllProducts().Returns(getListProductsEf);
            _mapper.Map<List<Products>>(getListProductsEf).Returns(getListProducts);
            //Act
            var result = await _sut.GetAllProductsPassThrough();
            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<List<Products>>();

        }



    }
}
