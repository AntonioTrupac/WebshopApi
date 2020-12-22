using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;
using Core.Specifications;

namespace Core.Interfaces
{
	public interface IGenericRepository<T> where T : BaseEntity
	{
		Task<T> GetByIdAsync(int id);
		Task<IReadOnlyList<T>> GetAll();
		Task<T> GetEntityWithSpec(ISpecification<T> specification);
		Task<IReadOnlyList<T>> ListAsync(ISpecification<T> specification); 
		Task AddEntity(T entity);
		Task<int> RemoveEntity(T entity);
		Task SaveAsync();
	}
}