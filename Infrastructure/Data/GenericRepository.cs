using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;
using Infrastructure;

namespace Infrastructure.Data {
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity {
        private readonly ChristmasDbContext _context;

        public GenericRepository(ChristmasDbContext context) {
            _context = context;
        }
        public Task<T> GetByIdAsync(int id) {
            throw new System.NotImplementedException();
        }

        public Task<IReadOnlyList<T>> GetAll() {
            throw new System.NotImplementedException();
        }
    }
}