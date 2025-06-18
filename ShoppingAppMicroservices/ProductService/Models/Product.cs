namespace ProductService.Models
{
    public class Product
    {
        public int Id { get; set; }           // Primary Key
        public string Name { get; set; }       // Product Name
        public string Description { get; set; } // Product Description
        public decimal Price { get; set; }     // Product Price
        public int StockQuantity { get; set; } // How many available
    }
}
