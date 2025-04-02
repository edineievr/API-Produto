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

        public void SetProductInactive(int id)
        {
            Product p = SearchProducById(id);
            p.SetInactive();
        }

        public void SetProductActive(int id)
        {
            Product p = SearchProducById(id);
            p.SetActive();
        }

        public void UpdateDescription(int id, string description)
        {
            Product p = SearchProducById(id);
            p.Update(description);

        }
    }
}

