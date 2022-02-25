using System.Collections.Generic;
using System;
using PierresBakery.Models;

// greeting w/ bread & pastry price; 
////  options: add bread, add pastry, view order, submit order
// get user input for bread or pastry
// get user input for quantity of ^^
// add to order
// offer add item or submit order
// display order complete order
// edit or /submit oder

class Program {
  public static void Main() {
    Console.WriteLine ("Welcome to Pierre's Bakery!");
    Console.WriteLine ("Bread: $5/ea | Buy 2 Get 1 FREE");
    Console.WriteLine ("Pastries: $2/ea | Buy 2 Get One 50% Off!");
    bool done = false;
    while (done == false) {
      Console.WriteLine("Please chooose from the menu (Bread/Pastry/View Order)");
      string userInput = Console.ReadLine().ToUpper();
      if (userInput == "BREAD") {
        Console.WriteLine("How many loaves would you like?");
        string stringQuanity = Console.ReadLine();
        int quantity = int.Parse(stringQuanity);
        Bread bread = new Bread(quantity);
        Console.WriteLine(quantity + "x Bread: $" + bread.GetPrice(quantity));
      } else if (userInput == "PASTRY") {
        Console.WriteLine("How many pastries would you like?");
        string stringQuanity = Console.ReadLine();
        int quantity = int.Parse(stringQuanity);
        Pastry pastry = new Pastry(quantity);
        Console.WriteLine(quantity + "x Pastry: $" + pastry.GetPrice(quantity));
      // } else if (userInput == "VIEW" || userInput == "VIEW ORDER") {
      //   Console.WriteLine( Bread(quantity) + "Bread: $" + bread.GetPrice(quantity) );
      //   Console.WriteLine( Pastry(quantity) + "Pastry: $" + pastry.GetPrice(quantity) );
      //   Console.WriteLine( "  Total: $" + ordertotal);
      //   // Console.WriteLine( "Would you like to modify your order? (Yes / No");
      // }
      }
    }
  }
}