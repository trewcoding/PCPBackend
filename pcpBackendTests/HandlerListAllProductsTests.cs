using API.DTOS.Products;
using API.Handlers;
using API.Queries;
using API.unitTests.MockData;
using AutoMapper;
using ServiceLayer.DetailsService;
using ServiceLayer.DTOS.Products;

namespace API.unitTests
{
    public class HandlerListAllProductsTests
    {
        private HandlerListAllProducts _sut;
        private readonly IMapper _mapper;
        private readonly IProductService _serviceLayer;
        private QueryListAllProducts _queryListAllProducts;
        private readonly CancellationToken _cancellationToken;

        public HandlerListAllProductsTests()
        {
            _mapper = Substitute.For<IMapper>();
            _serviceLayer = Substitute.For<IProductService>();
            _queryListAllProducts = Substitute.For<QueryListAllProducts>(); 
            _cancellationToken = new CancellationToken();
            _sut = new HandlerListAllProducts(_mapper, _serviceLayer);  
        }

        [Fact]
        public async Task Handle_Should_Return_ListProductsApi()
        {
            //Arrange
            var listProductsSl = MockDtoDataSl.listProductsSl();
            var listProductsApi = MockDataDtoApi.listProductsApi();

            _serviceLayer.GetAllProducts().Returns(listProductsSl);
            _mapper.Map<List<ProductsApi>>(listProductsSl).Returns(listProductsApi);
            //Act
            var result = await _sut.Handle(_queryListAllProducts, _cancellationToken);
            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<List<ProductsApi>>();
            result.Should().HaveCount(1);
        }


        //Arrange

        //Act

        //Assert
    }
}
