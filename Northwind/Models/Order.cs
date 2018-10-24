using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
    public class Order
    {
        public Product OrderedProduct { get; set; }
        public int Quantity { get; set; }
    }
}