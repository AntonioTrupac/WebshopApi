using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace WebShop.Controllers 
{
    [ApiController]
    [Route("api/productType")]
    
    public class ProductTypeController : ControllerBase 
    {
        private readonly IProductTypeRepository _repo;
        private readonly ILogger<ProductTypeController> _logger;
        private readonly IGenericRepository<ProductType> _genRepo;

        public ProductTypeController(IProductTypeRepository repo, IGenericRepository<ProductType> genRepo, ILogger<ProductTypeController> logger) 
        {
            _repo = repo;
            _logger = logger;
            _genRepo = genRepo;
        } 
        
        //get all 
        [HttpGet]
        public async Task<ActionResult<List<ProductType>>> GetAllProductTypes() {
            var productType = await _genRepo.GetAll();
            if (productType == null) {
                return NotFound();
            }

            return Ok(productType);
        }
        //get by id
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductType>> GetProductById(int id) {
            _logger.Log(LogLevel.Information, "{id}" + " " + id.ToString());
            var productTypeId = await _genRepo.GetByIdAsync(id);
            if (productTypeId == null) {
                return NotFound();
            }

            return Ok(productTypeId);
        }
    }
}