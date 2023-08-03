using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery2.Models;
using System;

namespace Bakery2.Tests
{
    [TestClass]
    public class VendorTests : IDisposable
    {
        public void Dispose()
        {
            Vendor.ClearAll();
        }

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

        [TestMethod]
        public void GetId_ReturnsVendorId()
        {
            string vendorName = "Eva's Cafe";
            string vendorDescription = "Vendor Description";

            Vendor newVendor = new Vendor(vendorName, vendorDescription);

            int result = newVendor.Id;

            Assert.AreEqual(1, result);

        }

        // [TestMethod]
        // public void GetAll_()
        // {

        // }
        // [TestMethod]
        // public void Get_()
        // {

        // }
    }
}
