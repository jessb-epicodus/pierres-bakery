using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic; 
using PierresBakery.Models; 

// create instance of bread
// add bread to order
// add quanttiy to order
// calculate bread order
// display order
// confirm/submit oder

namespace PierresBakery.Tests {
  [TestClass]
  public class BreadTests {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread() { 
      // arrange
      Bread bread = new Bread();
      // assert
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }
    [TestMethod]
    public void AddBread_ReturnsBread_String() { 
      // arrange
      string addBread = "bread";
      Bread bread = new Bread(addBread);
      // act
      string order = bread.AddBread;
      // assert
      Assert.AreEqual(addBread, order);
    }
    // [TestMethod]
    // public void GetQuantity_ReturnsQuantity_Quantity() { 
    //   // arrange
    //   string stringQuantity = "1";
    //   int quantity = int.Parse(stringQuantity);
    //   Bread bread = new Bread();
    //   // act
    //   int order = bread.Quantity;
    //   // assert
    //   Assert.AreEqual(order, 1);
    // }
  }
}