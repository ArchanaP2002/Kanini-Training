 

namespace ApiProject.Model_s
{
    public class Product //represents  product entity
    {
        public int Id { get; set; }
        public string ProductName { get; set; } // propertry

        public double Price { get; set; }
        public int City { get; set; }
       // public string Category { get; set; } // New field for category
    }
}

