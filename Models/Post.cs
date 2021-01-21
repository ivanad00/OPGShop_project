using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPG.Models;


namespace OPG.Models
{
    public class Post
    {
        public int post_id { get; set; }
        public Product product_id { get; set; }
        public Users user_id { get; set; }
        public string post_text { get; set; }
        public int post_date_time { get; set; }
    }
}
