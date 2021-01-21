using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPG.Models;

namespace OPG.Models
{
    public class Users
    {
        public int user_id { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string adress1 { get; set; }
        public string adress2 { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public int zip_code { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }
}
