

namespace OPG.Models
{
    public class OrderProduct
    {
        public int OrderProductId { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public string OrderId { get; set; }
        public Product Product { get; set; }
    }
}
