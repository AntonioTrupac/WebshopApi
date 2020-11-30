using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
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
        private readonly IProductRepository _repo;

        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }
        
        //get all
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts() {
            var products = await _repo.GetProductsAsync();
            if (products == null) {
                return NotFound();
            }
            
            return Ok(products);
        }
        
        //get by id
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductsById(int id) {
            
            var product = await _repo.GetProductByIdAsync(id);
           if (product == null) {
               return NotFound();
           }
           
           return Ok(product);
        }
    }
}