using CRUDapi.Entities;
using CRUDapi.Entities.Exceptions;
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

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _context.Products;



            return Ok(products);

        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            try
            {
                var product = _context.Products.Where(p => p.Id == id);

                return Ok(product);
            }
            catch (DomainException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            _context.Products.Add(product);

            return CreatedAtAction(nameof(GetById), new {id = _context.Products.;
        }
    }

