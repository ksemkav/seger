using System;
using Seger.Domain;
using MccSoft.WebApi.Pagination;

namespace Seger.App.Features.Products.Dto
{
    public class SearchProductDto : PagedRequestDto
    {
        public string? Search { get; set; }
        public ProductType? ProductType { get; set; }
        public DateOnly? LastStockUpdatedAt { get; set; }
    }
}
