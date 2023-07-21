using System.Collections.Generic;

namespace Bakery2.Models
{
    public class Vendor
    {
        public string VendorName { get; set; }
        public string VendorDescription { get; set; }

        public int Id { get; set; }
        private static List<Vendor> _instances = new List<Vendor> { };

        public Vendor(string vendorName, string vendorDescription, int id)
        {
            VendorName = vendorName;
            VendorDescription = vendorDescription;
            _instances.Add(this);
            Id = id;
        }

        public static List<Vendor> GetAll()
        {
            return _instances;
        }
    }



    public class Order
    {
        public string OrderTitle { get; set; }
        public string OrderDescription { get; set; }
        public int Price { get; set; }
        public int Date { get; set; }

    }
}