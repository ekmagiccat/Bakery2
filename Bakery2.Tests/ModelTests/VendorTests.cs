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

        [TestMethod]
        public void GetAll_ReturnsAllVendors_VendorList()
        {
            string vendorName = "Eva's Cafe";
            string vendorName2 = "Talia's Diner";
            string vendorDescription = "Vendor Description";

            Vendor newVendor1 = new Vendor(vendorName, vendorDescription);
            Vendor newVendor2 = new Vendor(vendorName2, vendorDescription);
            List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

            List<Vendor> result = Vendor.GetAll();

            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetFind_ReturnsCorrectVendor_Vendor()
        {

            string vendorName = "Eva's Cafe";
            string vendorName2 = "Talia's Diner";
            string vendorDescription = "Vendor Description";

            Vendor newVendor1 = new Vendor(vendorName, vendorDescription);
            Vendor newVendor2 = new Vendor(vendorName2, vendorDescription);

            Vendor result = Vendor.Find(2);

            Assert.AreEqual(newVendor2, result);
        }
        [TestMethod]
        public void AddOrder_AssociatesOrderWithVendor_OrderList()
        {
            string orderDescription = "Order Description";
            string orderTitle = "Order title";
            double price = 20.0;
            DateTime date = new DateTime(2023, 8, 2, 12, 34, 56);


            Order newOrder = new Order(orderDescription, orderTitle, price, date);
            List<Order> newList = new List<Order> { newOrder };
            string vendorName = "Eva's Cafe";
            string vendorDescription = "Vendor Description";
            Vendor newVendor = new Vendor(vendorName, vendorDescription);
            newVendor.AddOrder(newOrder);

            List<Order> result = newVendor.Orders;

            CollectionAssert.AreEqual(newList, result);
        }

    }
}
