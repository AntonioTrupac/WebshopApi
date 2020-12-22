using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data {
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity {
        private readonly ChristmasDbContext _context;

        public GenericRepository(ChristmasDbContext context) {
            _context = context;
        }
        public async Task<T> GetByIdAsync(int id) {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> GetAll() {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task AddEntity(T entity) {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        
        public async Task<int> RemoveEntity(T entity) {
            _context.Set<T>().Remove(entity);
            return await _context.SaveChangesAsync();
        }
        
        public async Task SaveAsync() 
        {
            await _context.SaveChangesAsync();
        }
    }
}