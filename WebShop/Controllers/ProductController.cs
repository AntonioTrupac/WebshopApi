using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace WebShop.Controllers
{
	[ApiController]
	[Route("api/product")]
	public class ProductController : ControllerBase
	{
		private readonly IProductRepository _repo;
		private readonly ILogger<ProductController> _logger;

		public ProductController(IProductRepository repo, ILogger<ProductController> logger)
		{
			_repo = repo;
			_logger = logger;
		}

		//get all
		[HttpGet]
		public async Task<ActionResult<List<Product>>> GetProducts()
		{
			var spec = new ProductsWithTypesSpecification();

			var products = await _repo.ListAsync(spec);

			if (products == null)
			{
				return NotFound();
			}

			return Ok(products);
		}

		//get by id
		[HttpGet("{id}")]
		public async Task<ActionResult<Product>> GetProductsById(int id)
		{
			_logger.Log(LogLevel.Information, "{id}" + " " + id);

			var product = await _repo.GetByIdAsync(id);
			if (product == null)
			{
				return NotFound();
			}

			return Ok(product);
		}

		/*[HttpPost]
		public async Task<ActionResult<Product>> CreateProduct(Product product) {
		    _repo.AddEntity();
		}*/

		[HttpDelete("{id}")]
		public async Task<ActionResult<Product>> DeleteProduct(int id)
		{
			var product = await _repo.GetByIdAsync(id);
			if (product == null)
			{
				return NotFound();
			}

			await _repo.RemoveEntity(product);
			await _repo.SaveAsync();
			return product;
		}
	}
}