using System;
using Seger.App.Features.Products.Dto;
using Seger.Domain;
using MccSoft.Testing.Infrastructure;

namespace Seger.TestUtils.Factories
{
    public static class ProductFactory
    {
        public static Product Product(this MotherFactory a, string title = "Default Product 1")
        {
            return new Product(title);
        }

        public static Http.Generated.CreateProductDto CreateProductGeneratedDto(
            this MotherFactory a,
            string title = "Default Product 1"
        )
        {
            return new()
            {
                Title = title,
                LastStockUpdatedAt = new DateTimeOffset(new DateTime(2020, 1, 1))
            };
        }

        public static CreateProductDto CreateProductDto(
            this MotherFactory a,
            string title = "Default Product 1"
        )
        {
            return new() { Title = title, };
        }
    }
}
