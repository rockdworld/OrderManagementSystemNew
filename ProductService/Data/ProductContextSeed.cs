using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using OrderMgmtSystem.ProductService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderMgmtSystem.ProductService.Data
{
    public class ProductContextSeed
    {
        public static void SeedData(IMongoCollection<Product> ProductCollection)
        {
            bool existProduct = ProductCollection.Find(p => true).Any();
            if (!existProduct)
            {
                ProductCollection.InsertManyAsync(GetPreconfiguredCustomers());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredCustomers()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "Pepsi",
                    Desc = "Pepsi",
                    Packing = "12 * 10",
                    Price = 10.5,
                    Rating = 3

                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "Thumps Up",
                    Desc = "Thumps Up",
                    Packing = "10 * 10",
                    Price = 12.5,
                    Rating = 4

                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f7",
                    Name = "Limca",
                    Desc = "Limca",
                    Packing = "15 * 10",
                    Price = 16.00,
                    Rating = 5
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f8",
                    Name = "Sprite",
                    Desc = "Sprite",
                    Packing = "20 * 10",
                    Price = 17.5,
                    Rating = 3
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f9",
                    Name = "Kingfisher",
                    Desc = "Kingfisher",
                    Packing = "10 * 10",
                    Price = 225.75,
                    Rating = 3
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47fa",
                    Name = "Karona",
                    Desc = "Karona",
                    Packing = "10 * 10",
                    Price = 210,
                    Rating = 3
                }
            };
        }
    }
}
