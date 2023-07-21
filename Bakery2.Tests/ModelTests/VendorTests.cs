using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery2.Models;
using System;

namespace Bakery2.Tests
{
    [TestClass]
    public class VendorTests
    {
        [TestMethod]
        public void VendorConstructor_CreatesNewVendor()
        {
            Vendor newVendor = new Vendor("Eva's Cafe", "Vendor Description", 1);
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetDescription_ReturnsVendorDescription()
        {
            string vendorName = "Eva's Cafe";
            string vendorDescription = "Vendor Description";
            int vendorId = 1;

            Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorId);
            string result = newVendor.VendorDescription;

            Assert.AreEqual(vendorDescription, result);
        }
    }
}
