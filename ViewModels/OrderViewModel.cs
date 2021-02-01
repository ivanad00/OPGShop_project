using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OPG.Models;

namespace OPG.ViewModels
{
    public class OrderViewModel
    {
        public Order Order { get; set; }
        public decimal OrderTotal { get; set; }
    }
}
