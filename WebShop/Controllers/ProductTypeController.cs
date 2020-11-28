using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebShop.Controllers 
{
    [ApiController]
    [Route("api/productType")]
    
    public class ProductTypeController : ControllerBase 
    {
        private readonly ChristmasDbContext _dbContext;

        public ProductTypeController(ChristmasDbContext dbContext) 
        {
            _dbContext = dbContext;
        } 
        
        //get all 
        [HttpGet]
        public async Task<ActionResult<List<ProductType>>> GetProductTypes() {
            var productType = await _dbContext.ProductTypes.ToListAsync();
            if (productType == null) {
                return NotFound();
            }

            return Ok(productType);
        }
        //get by id
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductType>> GetProductById(int id) {
            var productTypeId = await _dbContext.ProductTypes.FindAsync(id);
            if (productTypeId == null) {
                return NotFound();
            }

            return Ok(productTypeId);
        }
    }
}