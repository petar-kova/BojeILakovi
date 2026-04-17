using AcrylShop.Web.Data;
using AcrylShop.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcrylShop.Web.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _db;

    public HomeController(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<IActionResult> Index()
    {
        var model = new HomeIndexViewModel
        {
            SaleProducts = await _db.Products
                .Where(p => p.IsOnSale)
                .OrderBy(p => p.Price)
                .Take(4)
                .ToListAsync(),
            BestSellers = await _db.Products
                .OrderByDescending(p => p.UnitsSold)
                .Take(4)
                .ToListAsync()
        };

        return View(model);
    }
}
