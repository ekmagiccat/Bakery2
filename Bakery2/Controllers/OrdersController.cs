using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Bakery2.Models;

namespace Bakery2.Controllers
{
    public class OrdersController : Controller
    {

        [HttpGet("/vendors/{vendorId}/orders/new")]
        public ActionResult New(int vendorId)
        {
            Vendor vendor = Vendor.Find(vendorId);
            return View(vendor);
        }

        [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
        public ActionResult Show(int vendorId, string orderTitle, string orderDescription, double price, DateTime date, int orderId)
        {
            Order order = Order.Find(orderId);
            Vendor vendor = Vendor.Find(vendorId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            model.Add("order", order);
            model.Add("vendor", vendor);
            return View(model);
        }
    }
}

