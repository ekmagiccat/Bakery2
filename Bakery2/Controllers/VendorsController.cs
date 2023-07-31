using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Bakery2.Models;
using System;

namespace Bakery2.Controllers
{
    public class VendorsController : Controller
    {
        private static List<Vendor> _vendors = new List<Vendor>();

        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> vendorList = Vendor.GetAll();
            return View(vendorList);
        }

        [HttpGet("/vendors/new")]
        public ActionResult NewVendor()
        {
            return View();
        }

        [HttpPost("/vendors/new")]
        public ActionResult Create(string vendorName, string vendorDescription, int id)
        {
            Vendor myVendor = new Vendor(vendorName, vendorDescription, id);
            return RedirectToAction("Index");
        }
    }
}
