using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        
        [HttpGet]
        public IEnumerable<Product> GetAuthors()
        {
            using (var context = new WebShopDbContext())
            {    
                //get all products
                return context.Product.ToList();
            }
        }
    }
}