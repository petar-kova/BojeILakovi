using AcrylShop.Web.Data;
using AcrylShop.Web.Models;
using AcrylShop.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcrylShop.Web.Controllers;

public class ProductsController : Controller
{
    private readonly IProductQueryService _queryService;
    private readonly ApplicationDbContext _db;

    public ProductsController(IProductQueryService queryService, ApplicationDbContext db)
    {
        _queryService = queryService;
        _db = db;
    }

    public async Task<IActionResult> Index(string? sortBy, string? typeFilter, string? search)
    {
        var products = await _queryService.BuildFilteredQuery(sortBy, typeFilter, search).ToListAsync();
        var types = await _db.Products.Select(p => p.ProductType).Distinct().OrderBy(t => t).ToListAsync();

        return View(new ProductFilterViewModel
        {
            Products = products,
            SortBy = sortBy,
            TypeFilter = typeFilter,
            Search = search,
            AvailableTypes = types
        });
    }
}
