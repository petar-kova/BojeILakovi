using AcrylShop.Web.Models;

namespace AcrylShop.Web.Services;

public interface IProductQueryService
{
    IQueryable<Product> BuildFilteredQuery(string? sortBy, string? typeFilter, string? search);
}
