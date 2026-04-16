using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_LINQ02.Models
{
    internal class Customer
    {
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public List<Order> Orders { get; set; }
    }
}
