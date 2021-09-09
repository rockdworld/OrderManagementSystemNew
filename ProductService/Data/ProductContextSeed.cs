using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderMgmtSystem.ProductService.Data
{
    public class ProductContextSeed
    {
        public static async Task SeedAsync(ProductContext productContext, ILogger<ProductContextSeed> logger)
        {
            if (!productContext.Products.Any())
            {
                productContext.Products.AddRange(GetPreconfiguredProducts());
                await productContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(ProductContext).Name);
            }
        }

        private static IEnumerable<Models.Product> GetPreconfiguredProducts()
        {
            return new List<Models.Product>
            {
                new Models.Product() { Name = "Pepsi", Desc="Pepsi", Rating=5, Packing = "10*10", Price = 12.1 },
                new Models.Product() { Name = "Coca Cola", Desc="Coca Cola", Rating=3, Packing = "12*10", Price = 11.5 },
                new Models.Product() { Name = "Thumps Up", Desc="Thumps Up", Rating=4,Packing = "20*10", Price = 15 },
                new Models.Product() { Name = "Limca", Desc="Limca", Rating=2, Packing = "5*5", Price = 22 },
                new Models.Product() { Name = "Sprite", Desc="Sprite", Rating=1, Packing = "15*10", Price = 15 }
            };
        }
    }
}
