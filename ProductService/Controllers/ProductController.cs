using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderMgmtSystem.ProductService.Models;
using OrderMgmtSystem.ProductService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderMgmtSystem.ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductRepository ProductRepository;

        public ProductController(IProductRepository ProductRepository)
        {
            this.ProductRepository = ProductRepository;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await ProductRepository.GetProducts();
        }

    }
}
