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
    [Route("api/product")]
    
    public class ProductController: ControllerBase
    {
        private readonly ChristmasDbContext _context;

        public ProductController(ChristmasDbContext context)
        {
            _context = context;
        }
        
        //get all
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {    
            var products = await _context.Products.ToListAsync();
            if (products == null) {
                return NotFound();
            }
            
            return Ok(products);
        }
        
        //get by id
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductsById(int id) {
           var product = await _context.Products.FindAsync(id);
           if (product == null) {
               return NotFound();
           }
           
           return Ok(product);
        }
    }
}