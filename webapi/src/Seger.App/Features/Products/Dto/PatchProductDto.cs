using System;
using System.ComponentModel.DataAnnotations;
using Seger.Domain;
using MccSoft.WebApi.Patching.Models;

namespace Seger.App.Features.Products.Dto
{
    public class PatchProductDto : PatchRequest<Product>
    {
        [MinLength(3)]
        public string Title { get; set; }
        public ProductType ProductType { get; set; }

        public DateOnly LastStockUpdatedAt { get; set; }
    }
}
