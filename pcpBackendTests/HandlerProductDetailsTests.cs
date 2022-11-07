using API.DTOS.Product;
using API.Handlers;
using API.Queries;
using API.unitTests.MockData;
using AutoMapper;
using ServiceLayer.DetailsService;
using ServiceLayer.DTOS.Product;

namespace API.unitTests
{
    public class HandlerProductDetailsTests
    {
        public HandlerProductDetails _sut;
        private readonly IMapper _mapper;
        private readonly IProductService _serviceLayer;
        private readonly QueryProductDetails _queryProductDetails;
        private readonly CancellationToken _cancellationToken;
        
        public HandlerProductDetailsTests()
        {
            var productId = "ProductId1";
            _mapper = Substitute.For<IMapper>();
            _serviceLayer = Substitute.For<IProductService>();
            _queryProductDetails = Substitute.For<QueryProductDetails>(productId);
            _cancellationToken = new CancellationToken();
            _sut = new HandlerProductDetails(_mapper, _serviceLayer);
        }
        [Fact]
        public async Task Handle_Should_Return_ProductDetails()
        {
            //Arrange
            var productDataApi = MockDataDtoApi.productDataApi();
            var productDataSl = MockDtoDataSl.productDataSl();
            var productId = "ProductId1";

            _serviceLayer.GetProductDetails(productId).Returns(productDataSl);
            _mapper.Map<ProductDataApi>(productDataSl).Returns(productDataApi);

            //Act
            var result = await _sut.Handle(_queryProductDetails, _cancellationToken);
            //Assert
            result.Should().NotBeNull();
        }
    }
}

