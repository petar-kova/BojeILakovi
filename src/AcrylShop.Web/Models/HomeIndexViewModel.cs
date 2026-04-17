namespace AcrylShop.Web.Models;

public class HomeIndexViewModel
{
    public IEnumerable<Product> SaleProducts { get; set; } = Enumerable.Empty<Product>();
    public IEnumerable<Product> BestSellers { get; set; } = Enumerable.Empty<Product>();
}
