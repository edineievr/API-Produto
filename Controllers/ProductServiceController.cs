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
        private readonly ProductService _productService;

        public ProductServiceController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productService.ListProducts());
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            try
            {
                var product = _productService.SearchProducById(id);

                return Ok(product);
            }
            catch (DomainException e)
            {
                return NotFound(e.Message);
            }
        }

        /*[HttpPost]
        public IActionResult Post(Product product)
        {
            var p = _productService.AddProduct(p);

            return Created();
        }*/

        [HttpPut]
        public IActionResult Put(int id, string description) {

            var product = _productService.SearchProducById(id);

            product.Update(description);

            return Ok();

        }
    }
}

