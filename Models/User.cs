using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPG.Models;

namespace OPG.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<Rating> Rating { get; set; }
    }
}
