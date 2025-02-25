using CrudData.Server.Interfaces;
using StoreTestData.Models;

namespace CrudData.Server.Managers
{
    public class SalesOrderManager : ISalesOrderManager
    {
        public Task<IEnumerable<SalesOrderHeader>> GetSalesOrders()
        {
            throw new NotImplementedException();
        }
    }
}
