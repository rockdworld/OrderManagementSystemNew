using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using OrderMgmtSystem.ProductService.Models;

namespace OrderMgmtSystem.ProductService.Data
{
    public class ProductContext : IProductContext
    {
        public ProductContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));
            Products = database.GetCollection<Product>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));
            ProductContextSeed.SeedData(Products);
        }

        public IMongoCollection<Product> Products { get; }
    }
}
