using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPG.Models;


namespace OPG.Models
{
    public class Category
    {
        public int category_id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Product { get; set; }

      
    }
}
