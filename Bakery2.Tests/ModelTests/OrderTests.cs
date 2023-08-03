using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery2.Models;
using System;

namespace Bakery2.Tests
{
    [TestClass]
    public class OrderTests : IDisposable
    {

        public void Dispose()
        {
            Order.ClearAll();
        }
        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            string orderDescription = "Order Description";
            string orderTitle = "Order title";
            double price = 20.0;
            DateTime date = new DateTime(2023, 8, 2, 12, 34, 56);

            Order newOrder = new Order(orderDescription, orderTitle, price, date);
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            string orderDescription = "Order Description";
            string orderTitle = "Order title";
            double price = 20.0;
            DateTime date = new DateTime(2023, 8, 2, 12, 34, 56);

            Order newOrder = new Order(orderDescription, orderTitle, price, date);
            string result = newOrder.OrderDescription;

            Assert.AreEqual(orderDescription, result);
        }

        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            string orderDescription = "Order Description";
            string orderTitle = "Order title";
            double price = 20.0;
            DateTime date = new DateTime(2023, 8, 2, 12, 34, 56);
            Order newOrder = new Order(orderDescription, orderTitle, price, date);

            string updatedDescription = "Croissants";
            newOrder.OrderDescription = updatedDescription;
            string result = newOrder.OrderDescription;

            Assert.AreEqual(updatedDescription, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_OrderList()
        {
            List<Order> newList = new List<Order> { };

            List<Order> result = Order.GetAll();


            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetAll_ReturnsOrders_OrderList()
        {
            string orderDescription = "Order Description";
            string orderDescription2 = "Second Description";
            string orderTitle = "Order title";
            double price = 20.0;
            DateTime date = new DateTime(2023, 8, 2, 12, 34, 56);

            Order newOrder1 = new Order(orderDescription, orderTitle, price, date);
            Order newOrder2 = new Order(orderDescription2, orderTitle, price, date);
            List<Order> newList = new List<Order> { newOrder1, newOrder2 };

            List<Order> result = Order.GetAll();

            CollectionAssert.AreEqual(newList, result);
        }

    }
}
