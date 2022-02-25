using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic;
using PierresBakery.Models;

// create instance of pastry X
// add quanttiy to order
// price bread order

namespace PierresBakery.Tests {
  [TestClass]
  public class PastryTests {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry() { 
      // arrange
      Pastry pastry = new Pastry(4);
      // assert
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }
    [TestMethod]
    public void GetQuantity_ReturnsQuantity_Int() { 
      // arrange
      int quantity = 4;
      Pastry pastry = new Pastry(quantity);
      // act
      int order = pastry.Quantity;
      // assert
      Assert.AreEqual(4, order);
    }
    [TestMethod]
    public void GetPrice_ReturnsPrice_Int() { 
      // arrange
      int quantity = 4;
      Pastry pastry = new Pastry(quantity);
      // act
      int order = pastry.Quantity;
      // assert
      Assert.AreEqual(7, pastry.GetPrice(quantity));
    }
  }
}