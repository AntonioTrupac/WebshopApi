using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class ProductTypeRepository : GenericRepository<ProductType>, IProductTypeRepository
    {
        private readonly ChristmasDbContext _context;

        public ProductTypeRepository(ChristmasDbContext context) : base(context)
        {
            _context = context;
        }
    }
}