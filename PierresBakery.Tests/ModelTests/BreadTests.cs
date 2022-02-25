using Microsoft.VisualStudio.TestTools.UnitTesting; //imports the MSTest framework that we installed with the $ dotnet restore command.
// using System.Collections.Generic; //  for static methods;  needs static variable & declared instance. Both variables and methods dealing with entire classes must be static.  static method is called on the class itself, not on an instance of the class
using PierresBakery; //imports the namespace from the project for use in our tests

namespace PierresBakery.Tests {
  [TestClass]  //  tells MSTest that the following class contains tests to be run.
  public class BreadTests {
    // Test methods
    [TestMethod]  //  tells the compiler that the following code block is an individual test that MSTest will run.
    NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue() {  //  MSTest tests are actually methods.  They are public, which allows the tools running our tests to access them. We add void because they don't explicitly return anything.
      // arrange: gather, declare and create all necessary components for the test
      Bread testBread = new Bread();  //    ie. create an instance of class OR dont if using static method
      // act: invoke the functionality we're testing, often by calling a method or retrieving a property
      // assert: confirm the functionality works as anticipated by comparing its actual output with the anticipated output
      Assert.Method(expectedrestult, testBread.Method(testvalue)); //   write our first assertion using a method.  The first argument is what we expect the result of the test to be. The second is the expression to be evaluated.
    }
  }
}