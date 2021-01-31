using System.Collections.Generic;



namespace OPG.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Product> Product { get; set; }

      
    }
}
