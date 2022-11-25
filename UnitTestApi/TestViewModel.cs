using ApiViewModel;
using ApiViewModel.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestApi
{
    /// <summary>
    /// Summary description for TestViewModel
    /// </summary>
    [TestClass]
    public class TestViewModel
    {
        ApiViewModel.ApiViewModel model = new ApiViewModel.ApiViewModel();
        

        [TestMethod]
        public void TestMethodLocations()
        {
            var result = model.GetLocations();
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
        }
        [TestMethod]
        public void TestMethodOffers()
        {
            var result = model.GetOffers(1);
            Assert.IsNotNull(result);
            Assert.AreEqual(20, result.Count);

        }
        [TestMethod]
        public void TestMethodCreateReservation()
        {
            var reservation = new Reservations();
            reservation.OfferUId= "78e62f5";
            reservation.Customer = new Customer() { Name = "Test", Surname = "Testovich" };
            var result = model.CreateReservation(reservation);
            Assert.IsNotNull(result);
           // Assert.AreEqual(20, result.Count);

        }
    }
}
