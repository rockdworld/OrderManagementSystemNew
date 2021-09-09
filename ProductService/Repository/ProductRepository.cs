using MongoDB.Driver;
using OrderMgmtSystem.ProductService.Data;
using OrderMgmtSystem.ProductService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderMgmtSystem.ProductService.Repository
{

    

    public class ProductRepository : IProductRepository
    {
        IProductContext context;
        public ProductRepository(IProductContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var customers = await context.Products
                                            .Find(c => true)
                                            .ToListAsync<Product>();

            return customers;
        }
    }
}
