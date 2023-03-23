namespace SP3Project.API.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int Quntity { get; set; }
    }
}