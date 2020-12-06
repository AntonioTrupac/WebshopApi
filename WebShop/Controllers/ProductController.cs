using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace WebShop.Controllers
{    
    [ApiController]
    [Route("api/product")]
    
    public class ProductController: ControllerBase
    {
        private readonly IProductRepository _repo;
        private readonly IGenericRepository<Product> _genRepo;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IProductRepository repo, IGenericRepository<Product> genRepo, ILogger<ProductController> logger) {
            _repo = repo;
            _genRepo = genRepo;
            _logger = logger;
            
        }
        
        //get all
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts() {
            var products = await _genRepo.GetAll();
            
            if (products == null) {
                
                return NotFound();
            }
            
            return Ok(products);
        }
        
        //get by id
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductsById(int id) {
            _logger.Log(LogLevel.Information, "{id}" + " " + id);
            var product = await _genRepo.GetByIdAsync(id);
           if (product == null) {
               return NotFound();
           }
           
           return Ok(product);
        }

        /*[HttpPost]
        public async Task<IActionResult<Product>> CreateProduct(Product product) {
            
        }*/
    }
}