using AcrylShop.Web.Models;

namespace AcrylShop.Web.Data;

public static class SeedData
{
    public static void Initialize(ApplicationDbContext db)
    {
        if (db.Products.Any())
        {
            return;
        }

        db.Products.AddRange(
            new Product { Name = "Acrylic Basic Set 24", Brand = "ColorPro", ProductType = "Set", Price = 24.99m, IsOnSale = true, UnitsSold = 350, Description = "Set od 24 akrilne boje za početnike i napredne.", ImageUrl = "https://images.unsplash.com/photo-1452860606245-08befc0ff44b" },
            new Product { Name = "Titanium White 250ml", Brand = "StudioMix", ProductType = "Boja", Price = 6.20m, IsOnSale = false, UnitsSold = 480, Description = "Visokopokrivna bijela boja za podloge i miješanje.", ImageUrl = "https://images.unsplash.com/photo-1513364776144-60967b0f800f" },
            new Product { Name = "Gloss Gel Medium", Brand = "ArtCraft", ProductType = "Medium", Price = 8.75m, IsOnSale = true, UnitsSold = 210, Description = "Gel medium za sjaj i produženje vremena sušenja.", ImageUrl = "https://images.unsplash.com/photo-1579783900882-c0d3dad7b119" },
            new Product { Name = "Flat Brush #12", Brand = "BrushLine", ProductType = "Kist", Price = 4.90m, IsOnSale = false, UnitsSold = 190, Description = "Ravni sintetički kist idealan za veće površine.", ImageUrl = "https://images.unsplash.com/photo-1460661419201-fd4cecdf8a8b" },
            new Product { Name = "Acrylic Retarder", Brand = "StudioMix", ProductType = "Medium", Price = 7.40m, IsOnSale = false, UnitsSold = 170, Description = "Retarder usporava sušenje i olakšava blendanje.", ImageUrl = "https://images.unsplash.com/photo-1460661419201-fd4cecdf8a8b" },
            new Product { Name = "Professional Acrylic Set 48", Brand = "ColorPro", ProductType = "Set", Price = 46.99m, IsOnSale = true, UnitsSold = 420, Description = "Profesionalni set od 48 boja bogatog pigmenta.", ImageUrl = "https://images.unsplash.com/photo-1513364776144-60967b0f800f" }
        );

        db.SaveChanges();
    }
}
