using CRUDapi.Entities.Exceptions;
using CRUDapi.Entities;

namespace CRUDapi.Entities
{
    public class Product
    {
        public bool IsActive { get; private set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public List<Characteristics> Characteristics { get; set; } = new List<Characteristics>();            

        public Product()
        {

        }

        public Product(int id, string description, double quantity, double price)
        {
            IsActive = true;
            Id = id;
            Description = description;

            if (quantity < 0.00)
            {
                throw new DomainException("Quantity must be higher than 0!");
            }
            else
            {
                Quantity = quantity;
            }

            if (price < 0.00)
            {
                throw new DomainException("Price must not be negative!");
            }
            else
            {
                Price = price;
            }
        }

        public void SetInactive()
        {
            IsActive = false;
        }

        public void SetActive()
        {
            IsActive = true;
        }

        public void Update(string description)
        {
            if (description == null)
            {
                throw new DomainException("Descripton must not be null");
            }
            else
            {
                Description = description;
            }
        }
    }
}

