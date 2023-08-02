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
            Vendor newVendor = new Vendor("Eva's Cafe", "Vendor Description");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetDescription_ReturnsVendorDescription()
        {
            string vendorName = "Eva's Cafe";
            string vendorDescription = "Vendor Description";

            Vendor newVendor = new Vendor(vendorName, vendorDescription);
            string result = newVendor.VendorDescription;

            Assert.AreEqual(vendorDescription, result);
        }
        [TestMethod]
        public void SetVendorDescription_SetVendorDescription_String()
        {

            string vendorName = "Eva's Cafe";
            string vendorDescription = "Vendor Description";

            Vendor newVendor = new Vendor(vendorName, vendorDescription);


            string updatedDescription = "Newly updated";
            newVendor.VendorDescription = updatedDescription;
            string result = newVendor.VendorDescription;


            Assert.AreEqual(updatedDescription, result);
        }
    }
}
