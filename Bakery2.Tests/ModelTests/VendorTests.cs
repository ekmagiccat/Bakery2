using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery2.Models;
using System;

namespace Bakery2.Tests
{
    [TestClass]
    public class VendorTests
    {

        Vendor _instanceofVendor = new Vendor();

        [TestMethod]
        public void VendorConstructor_CreatesNewVendor()
        {
            Vendor newVendor = new Vendor();
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }
    }
}