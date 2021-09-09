using OrderMgmtSystem.ProductService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderMgmtSystem.ProductService.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
