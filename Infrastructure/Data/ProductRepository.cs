using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data {
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ChristmasDbContext _context;

        public ProductRepository(ChristmasDbContext context) : base(context)
        {
            _context = context;
        }

        //specific repo methods
    }
}