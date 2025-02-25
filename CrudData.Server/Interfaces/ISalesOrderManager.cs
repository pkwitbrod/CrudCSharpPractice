using StoreTestData.Models;

namespace CrudData.Server.Interfaces
{
    public interface ISalesOrderManager
    {
        Task<IEnumerable<SalesOrderHeader>> GetSalesOrders();
    }
}
