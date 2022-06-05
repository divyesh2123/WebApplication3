using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class ProductViewModel
    {
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Stock { get; set; }
    }
}