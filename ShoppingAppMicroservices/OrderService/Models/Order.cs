namespace OrderService.Models
{
    public class Order
    {
        public int Id { get; set; }
       // public int UserId { get; set; } // FK to User
        public int ProductId { get; set; } // FK to Product
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } // Pending, Completed, Cancelled

    }
}
