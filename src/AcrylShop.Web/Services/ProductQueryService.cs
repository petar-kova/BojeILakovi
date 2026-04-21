using AcrylShop.Web.Data;
using AcrylShop.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace AcrylShop.Web.Services;

public class ProductQueryService : IProductQueryService
{
    private readonly ApplicationDbContext _db;

    public ProductQueryService(ApplicationDbContext db)
    {
        _db = db;
    }

    public IQueryable<Product> BuildFilteredQuery(string? sortBy, string? typeFilter, string? search)
    {
        var query = _db.Products.AsNoTracking().AsQueryable();

        if (!string.IsNullOrWhiteSpace(typeFilter))
        {
            query = query.Where(p => p.ProductType == typeFilter);
        }

        if (!string.IsNullOrWhiteSpace(search))
        {
            query = query.Where(p => p.Name.Contains(search) || p.Brand.Contains(search));
        }

        query = sortBy switch
        {
            "price_asc" => query.OrderBy(p => p.Price),
            "price_desc" => query.OrderByDescending(p => p.Price),
            "type" => query.OrderBy(p => p.ProductType).ThenBy(p => p.Name),
            _ => query.OrderByDescending(p => p.UnitsSold)
        };

        return query;
    }
}
