using CRUDapi.Entities;

namespace CRUDapi.Persistence
{
    public class ProductDbContext
    {
        public List<Product> Products { get; set; }

        public ProductDbContext()
        {
            Products = new List<Product>();
        }
    }
}
