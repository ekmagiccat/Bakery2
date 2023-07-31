using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bakery2.Models
{
    public class VendorsController : Controller
    {

        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> VendorList = Vendor.GetAll();
            return View(VendorList);
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