using StoreTestData.Models;

namespace CrudData.Server.Interfaces
{
    public interface IProductManager
    {
        Task<IEnumerable<Product>> GetProductList();
    }
}
