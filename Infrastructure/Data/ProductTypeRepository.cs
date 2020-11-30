using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure {
    public class ProductTypeRepository : IProductTypeRepository {
        
        private readonly ChristmasDbContext _context;

        public ProductTypeRepository(ChristmasDbContext context) {
            _context = context;
        }
        
        public async Task<ProductType> GetProductTypeById(int id) {
            return await _context.ProductTypes.FindAsync(id);
        }

        public async Task<IReadOnlyList<ProductType>> GetAllProductTypes() {
            return await _context.ProductTypes.ToListAsync();
        }
    }
}