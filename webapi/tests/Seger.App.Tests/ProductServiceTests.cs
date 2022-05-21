using System.Threading.Tasks;
using FluentAssertions;
using MccSoft.IntegreSql.EF.DatabaseInitialization;
using Seger.App.Features.Products;
using Seger.App.Utils;
using Seger.TestUtils.Factories;
using MccSoft.Testing;
using Microsoft.Extensions.Logging.Abstractions;
using Xunit;

namespace Seger.App.Tests
{
    public class ProductServiceTests : AppServiceTestBase<ProductService>
    {
        private readonly DateTimeProvider _time = new();

        public ProductServiceTests() : base(DatabaseType.Postgres)
        {
            var logger = new NullLogger<ProductService>();

            Sut = InitializeService((retryHelper, db) => new ProductService(db));
        }

        [Fact]
        public async Task Create()
        {
            var result = await Sut.Create(a.CreateProductDto("asd"));
            result.Title.Should().Be("asd");
        }

        [Fact]
        public async Task Get()
        {
            var createResult = await Sut.Create(a.CreateProductDto("asd"));
            var getResult = await Sut.Get(createResult.Id);
            getResult.Title.Should().Be("asd");
        }
    }
}
