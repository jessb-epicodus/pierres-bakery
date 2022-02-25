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
      Bread newBread = new Bread();
      // assert
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
        [TestMethod]
    public void GetOrder_ReturnsOrder_Int() { 
      // arrange
      int order = 1;
      Bread newBread = new Bread(order);
      // act
      int result = newBread.Bread;
      // assert
      Assert.AreEqual(order, 1);
    }
  }
}