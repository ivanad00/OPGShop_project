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
        public int RatingId { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
        public string Note { get; set; }
    }
}