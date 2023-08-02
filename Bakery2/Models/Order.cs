using System.Collections.Generic;
using System;

namespace Bakery2.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderTitle { get; set; }
        public string OrderDescription { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        private static List<Order> _instances = new List<Order> { };

        public Order(string orderDescription, string orderTitle, double price, DateTime date)
        {
            OrderDescription = orderDescription;
            OrderTitle = orderTitle;
            Price = price;
            Date = date;
            _instances.Add(this);
            OrderId = _instances.Count;
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Order Find(int searchId)
        {
            return _instances[searchId - 1];
        }

    }
}