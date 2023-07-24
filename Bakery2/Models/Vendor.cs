using System.Collections.Generic;

namespace Bakery2.Models
{
    public class Vendor
    {
        public static Dictionary<string, Vendor> Lists { get; } = new Dictionary<string, Vendor>();

        public string VendorName { get; set; }
        public string VendorDescription { get; set; }
        public int Id { get; set; }

        public Dictionary<string, List<Order>> Orders { get; } = new Dictionary<string, List<Order>>();

        public Vendor(string vendorName, string vendorDescription, int id)
        {
            VendorName = vendorName;
            VendorDescription = vendorDescription;
            Lists.Add(vendorName, this);
            Id = id;
        }

        public void AddOrder(string vendorName, Order order)
        {
            if (Orders.ContainsKey(vendorName))
            {
                Orders[vendorName].Add(order);
            }
            else
            {
                Orders[vendorName] = new List<Order> { order };
            }
        }

        public static List<Vendor> GetAll()
        {
            return new List<Vendor>(Lists.Values);
        }
    }
}



