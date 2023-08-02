using System.Collections.Generic;

namespace Bakery2.Models
{
    public class Vendor
    {
        private static List<Vendor> _instances = new List<Vendor> { };
        // public static Dictionary<string, Vendor> Lists { get; } = new Dictionary<string, Vendor>();

        public string VendorName { get; set; }
        public string VendorDescription { get; set; }
        public int Id { get; }
        public List<Order> Orders { get; set; }

        // public Dictionary<string, List<Order>> Orders { get; } = new Dictionary<string, List<Order>>();

        public Vendor(string vendorName, string vendorDescription)
        {
            VendorName = vendorName;
            VendorDescription = vendorDescription;
            _instances.Add(this);
            Id = _instances.Count;
            Orders = new List<Order> { };
        }

        // public void AddOrder(string vendorName, Order order)
        // {
        //     if (Orders.ContainsKey(vendorName))
        //     {
        //         Orders[vendorName].Add(order);
        //     }
        //     else
        //     {
        //         Orders[vendorName] = new List<Order> { order };
        //     }
        // }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static List<Vendor> GetAll()
        {
            return _instances;
        }
        public static Vendor Find(int searchId)
        {
            return _instances[searchId - 1];
        }
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }
}



