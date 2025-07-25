namespace ThreadAndDaringStore.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order? Order{ get; set; }
        public int ProductId { get; set; }
        public Product? Product{ get; set; }
        public string Quantity { get; set; } = string.Empty;
        public decimal Price { get; set; }
        
    }
}