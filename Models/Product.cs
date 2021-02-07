using System.Collections.Generic;

namespace OPG.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ProductDescription { get; set; }
        public float Discount { get; set; }
        public Category Category { get; set; }
    }
}