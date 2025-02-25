using CrudData.Server.Interfaces;
using CrudData.Server.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreTestData.Models;

namespace CrudData.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderContorller: ControllerBase
    {
       private readonly ISalesOrderManager _salesOrderManager;

       public SalesOrderContorller(ISalesOrderManager salesOrderManager) 
        {
            _salesOrderManager = salesOrderManager;
        }

        [HttpGet]
        public async Task<IEnumerable<SalesOrderHeader>> GetSalesOrderHeaders()
        {
            return await _salesOrderManager.GetSalesOrders();
        }
         

    }
}
