using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG.Models
{
    public class Post
    {
        public int Post_ID { get; set; }
        public int Product_ID { get; set; }
        public int User_ID { get; set; }
        public string Post_Text { get; set; }
        public int Post_Date_Time { get; set; }
    }
}
