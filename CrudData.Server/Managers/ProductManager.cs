using CrudData.Server.Interfaces;
using StoreTestData.Models;

namespace CrudData.Server.Managers
{
    public class ProductManager: IProductManager
    {
        public async Task<IEnumerable<Product>> GetProductList()
        {
            throw new NotImplementedException();
        }
    }
}
