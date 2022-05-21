using System;
using System.ComponentModel.DataAnnotations;
using Seger.Domain;
using Newtonsoft.Json;

namespace Seger.App.Features.Products.Dto
{
    public class CreateProductDto
    {
        [Required]
        [MinLength(3)]
        public string Title { get; set; }

        public ProductType ProductType { get; set; }

        public DateOnly LastStockUpdatedAt { get; set; }
    }
}
