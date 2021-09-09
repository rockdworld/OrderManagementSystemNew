using MongoDB.Driver;
using OrderMgmtSystem.ProductService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderMgmtSystem.ProductService.Data
{
    public interface IProductContext
    {
        public IMongoCollection<Product> Products { get; }
    }
}
