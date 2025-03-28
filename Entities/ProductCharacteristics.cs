namespace CRUDapi.Entities
{
    public class Characteristics
    {
        public string Characteristic { get; set; }
        public string Color { get; set; }

        public Characteristics()
        {
            
        }

        public Characteristics(string characteristics, string color)
        {
            Characteristic = characteristics;
            Color = color;            
        }
    }

    
}
