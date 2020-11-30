using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure;

namespace Core.Interfaces {
    public interface IProductTypeRepository {
        public Task<ProductType> GetProductTypeById(int id);
        public Task<IReadOnlyList<ProductType>> GetAllProductTypes();
    }
}