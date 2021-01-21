using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG.Models
{
    public class Users
    {
        public int UsersID { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Firsta_Name { get; set; }
        public string Last_Name { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Zip_code { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }
}
