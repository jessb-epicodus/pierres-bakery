using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic; 
using PierresBakery.Models; 

// create instance of bread
// get bread order
// calculate bread order

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
  }
}