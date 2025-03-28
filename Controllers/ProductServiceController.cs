using CRUDapi.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDapi.Controllers
{
    [Route("api/product-service")]
    [ApiController]
    public class ProductServiceController : ControllerBase
    {
        private readonly ProductDbContext _context;

        public ProductServiceController(ProductDbContext context)
        {
            _context = context;
        }

        //[HttpGet]
    }
}

