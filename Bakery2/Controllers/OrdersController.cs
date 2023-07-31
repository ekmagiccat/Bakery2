using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Bakery2.Models;

namespace Bakery2.Controllers
{
    public class OrdersController : Controller
    {
        private static List<Order> _orders = new List<Order>();

        [HttpGet("/orders/new")]
        public ActionResult NewOrder()
        {
            return View();
        }

        [HttpPost("/orders/new")]
        public ActionResult CreateOrder(string orderTitle, string orderDescription, double price, DateTime date)
        {
            Order newOrder = new Order
            {
                OrderTitle = orderTitle,
                OrderDescription = orderDescription,
                Price = price,
                Date = date
            };

            _orders.Add(newOrder);

            return RedirectToAction("ShowOrder");
        }
    }
}

