using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic;
using PierresBakery.Models;

// create instance of pastry
// add quanttiy to order
// price bread order

namespace PierresBakery.Tests {
  [TestClass]
  public class PastryTests {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry() { 
      // arrange
      Pastry pastry = new Pastry();
      // assert
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }
  }
}