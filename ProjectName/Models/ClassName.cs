// using System.Collections.Generic; //  for static methods;  needs static variable & declared instance. Both variables and methods dealing with entire classes must be static.  static method is called on the class itself, not on an instance of the class

namespace ProjectName.Models {  //  place logic in the namespace.
  public class ClassName {  //  create a class that contains the method & expected return
    // properties, methods, etc.
    public datatype FunctionName(datatype variable) {
      // logic 
      return expectedoutcome;  //  identify a behavior and write a corresponding test before adding any application logic. EX: return false as a placeholder so the application can compile properly. If our method returned nothing, we'd receive errors because the method has expected return withcorresponding with the datatype.
    }
  }
}