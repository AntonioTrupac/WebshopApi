using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure {
    
    public class ProductRepository : IProductRepository {
        private readonly ChristmasDbContext _context;

        public ProductRepository(ChristmasDbContext context) {
            _context = context;
        }
        public async Task<Product> GetProductByIdAsync(int id) {
            return await _context.Products.FindAsync(id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync() {
            var products = await _context.Products.ToListAsync();
            return products;
        }
    }
}