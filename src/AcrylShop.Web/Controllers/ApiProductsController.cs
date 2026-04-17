using AcrylShop.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcrylShop.Web.Controllers;

[ApiController]
[Route("api/products")]
public class ApiProductsController : ControllerBase
{
    private readonly IProductQueryService _queryService;

    public ApiProductsController(IProductQueryService queryService)
    {
        _queryService = queryService;
    }

    [HttpGet]
    public async Task<IActionResult> Get(string? sortBy, string? typeFilter, string? search)
    {
        var products = await _queryService.BuildFilteredQuery(sortBy, typeFilter, search).ToListAsync();
        return Ok(products);
    }
}
