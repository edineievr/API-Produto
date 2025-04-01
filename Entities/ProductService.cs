using CRUDapi.Entities;
using CRUDapi.Entities.Exceptions;
using CRUDapi.Persistence;

namespace CRUDapi.Entities
{
    public class ProductService
    {
        private readonly ProductDbContext _context;

        public ProductService(ProductDbContext context)
        {
            _context = context;
        }
        public void AddProduct(Product p)
        {
            _context.Products.Add(p);
        }

        public List<Product> ListProducts()
        {
            return _context.Products;
        }

        public Product SearchProducById(int id)
        {
            Product p = _context.Products.Find(x => x.Id == id);

            if (p == null)
            {
                throw new DomainException("Product not found!");
            }
            return p;
        }

        public void SetProductInactive(int codigo)
        {
            Product p = SearchProducById(codigo);
            p.SetInactive();
        }

        public void SetProductActive(int codigo)
        {
            Product p = SearchProducById(codigo);
            p.SetActive();
        }
    }
}

