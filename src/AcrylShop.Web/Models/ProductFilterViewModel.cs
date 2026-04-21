namespace AcrylShop.Web.Models;

public class ProductFilterViewModel
{
    public IEnumerable<Product> Products { get; set; } = Enumerable.Empty<Product>();
    public string? SortBy { get; set; }
    public string? TypeFilter { get; set; }
    public string? Search { get; set; }
    public IEnumerable<string> AvailableTypes { get; set; } = Enumerable.Empty<string>();
}
