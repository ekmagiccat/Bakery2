using Microsoft.AspNetCore.Mvc;
using Bakery2.Models;
using System.Collections.Generic;

namespace Bakery2.Models
{
    public class VendorController : Controller
    {

        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> VendorList = Vendor.GetAll();
            return View(VendorList);
        }

        [HttpGet("/vendors/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string vendorName, string vendorDescription, int id)
        {
            Vendor myVendor = new Vendor(vendorName, vendorDescription, id);
            return RedirectToAction("Index");
        }

    }
}