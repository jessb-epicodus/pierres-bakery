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
  }
}