using System.Collections.Generic;
using System;

namespace Bakery2.Models
{
    public class Order
    {
        public string OrderTitle { get; set; }
        public string OrderDescription { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }

    }
}