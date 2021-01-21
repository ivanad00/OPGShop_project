using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPG.Models;


namespace OPG.Models
{
    public class Rating
    {
        public int rating_id { get; set; }
        public Users user_id { get; set; }
        public Product product_id { get; set; }
        public string Note { get; set; }
    }
}
