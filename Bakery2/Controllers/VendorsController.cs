using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Bakery2.Models;
using System;

namespace Bakery2.Controllers
{
    public class VendorsController : Controller
    {

        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> vendorList = Vendor.GetAll();
            return View(vendorList);
        }

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string vendorName, string vendorDescription, int id)
        {
            Vendor myVendor = new Vendor(vendorName, vendorDescription);
            return RedirectToAction("Index");
        }

        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(id);
            List<Order> vendorOrders = selectedVendor.Orders;
            model.Add("vendor", selectedVendor);
            model.Add("orders", vendorOrders);
            return View(model);
        }
        [HttpPost("/vendors/{vendorId}/orders")]
        public ActionResult Create(int vendorId, string orderDescription, string orderTitle, double price, DateTime date)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor foundVendor = Vendor.Find(vendorId);
            Order newOrder = new Order(orderDescription, orderTitle, price, date);
            foundVendor.AddOrder(newOrder);
            List<Order> vendorOrders = foundVendor.Orders;
            model.Add("orders", vendorOrders);
            model.Add("vendor", foundVendor);
            return View("Show", model);
        }
    }
}
