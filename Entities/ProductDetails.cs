namespace graphql_demo.Entities
{
    public class ProductDetails
    {
        public Guid Id { get; set; }
        public required string ProductName { get; set; }
        public required string ProductDescription { get; set; }
        public int ProductPrice { get; set; }
        public int ProductStock { get; set; }

    }
}