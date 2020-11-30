using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebShop.Controllers 
{
    [ApiController]
    [Route("api/productType")]
    
    public class ProductTypeController : ControllerBase 
    {
        private readonly IProductTypeRepository _repo;

        public ProductTypeController(IProductTypeRepository repo) 
        {
            _repo = repo;
        } 
        
        //get all 
        [HttpGet]
        public async Task<ActionResult<List<ProductType>>> GetAllProductTypes() {
            var productType = await _repo.GetAllProductTypes();
            if (productType == null) {
                return NotFound();
            }

            return Ok(productType);
        }
        //get by id
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductType>> GetProductById(int id) {
            var productTypeId = await _repo.GetProductTypeById(id);
            if (productTypeId == null) {
                return NotFound();
            }

            return Ok(productTypeId);
        }
    }
}