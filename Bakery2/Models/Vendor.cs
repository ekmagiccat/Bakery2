using System.Collections.Generic;

namespace Bakery2.Models
{
    public class Vendor
    {
        public string VendorName { get; set; }
        public string VendorDescription { get; set; }

        public int Id { get; }

    }

    public class Order
    {
        public string OrderTitle { get; set; }
        public string OrderDescription { get; set; }
        public int Price { get; set; }
        public int Date { get; set; }


    }
}