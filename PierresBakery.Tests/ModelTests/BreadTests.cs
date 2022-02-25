using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic; 
using PierresBakery.Models; 

// create instance of bread
// add bread to order
// calculate bread order
// display order
// confirm/submit oder

namespace PierresBakery.Tests {
  [TestClass]
  public class BreadTests {
    [TestMethod]
    public void NewBread_CreateInstanceOfBread_Bread() { 
      // arrange
      Bread bread = new Bread();
      // assert
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }
    [TestMethod]
    public void GetQuantity_ReturnsQuantity_Quantity() { 
      // arrange
      string stringQuantity = "1";
      int quantity = int.Parse(stringQuantity);
      Bread bread = new Bread();
      // act
      int order = bread.Quantity;
      // assert
      Assert.AreEqual(order, 1);
    }
  }
}