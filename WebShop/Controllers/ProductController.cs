using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebShop.Models;

namespace WebShop.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    
    public class ProductController: ControllerBase
    {
        private readonly postgresContext _context;

        public ProductController(postgresContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {    
            var products = await _context.Product.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductsById(int id)
        {
            var product = await _context.Product.FirstOrDefaultAsync(prod => prod.ProductId == id);
            return Ok(product);
        }
    }
}