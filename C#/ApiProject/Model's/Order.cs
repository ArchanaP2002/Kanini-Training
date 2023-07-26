namespace ApiProject.Model_s
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }

        // Navigation property for the associated product
        public Product Product { get; set; }
    }
}

