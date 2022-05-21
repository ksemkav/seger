using System;
using Seger.Domain;
using Newtonsoft.Json;

namespace Seger.App.Features.Products.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ProductType ProductType { get; set; }

        public DateOnly LastStockUpdatedAt { get; set; }
    }
}
