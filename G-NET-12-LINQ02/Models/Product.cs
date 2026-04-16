using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_LINQ02.Models
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public string Category { get; set; }
    }
}
