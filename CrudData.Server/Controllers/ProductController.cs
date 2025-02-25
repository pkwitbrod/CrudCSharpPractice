using CrudData.Server.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreTestData.Models;

namespace CrudData.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly CrudDbContext _context;
        private readonly IProductManager _productManager;

        public ProductController(CrudDbContext context, IProductManager productManager)
        {
            _context = context;
            _productManager = productManager;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            try
            {
                await _productManager.GetProductList();
                return await _context.Products.ToListAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw;
            }
           
        }
    }
}
