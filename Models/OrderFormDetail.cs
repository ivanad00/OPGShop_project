namespace OPG.Models
{
    public class OrderFormDetail
    {
       public int OrderFormDetailId { get; set; }
        public int OrderFormId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Product Product { get; set; }
        public OrderForm OrderForm { get; set; }
    }
}
