using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace WebShop.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    
    public class ProductController: ControllerBase
    {
        private readonly ChristmasDbContext _context;

        public ProductController(ChristmasDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {    
            var products = await _context.Product.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductsById(int id)
        {
            var product = await _context.Product.FindAsync(id);
            return Ok(product);
        }
    }
}