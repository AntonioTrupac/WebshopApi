using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Interfaces {
    public interface IGenericRepository<T> where T : BaseEntity {
        
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAll();
        Task AddEntity(T entity);
        Task<int> RemoveEntity(T entity);
        Task SaveAsync();
    }
}