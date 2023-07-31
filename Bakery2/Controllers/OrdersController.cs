using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bakery2.Models
{
    public class OrdersController : Controller
    {
        [HttpGet("/orders")]
        public ActionResult Index()
        {
            List<Vendor> VendorList = Vendor.GetAll();
            return View(VendorList);
        }
    }
}
