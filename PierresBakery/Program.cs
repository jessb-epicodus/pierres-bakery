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
    List<Bread> BreadOrder = new List<Bread> {};
    List<Pastry> PastryOrder = new List<Pastry> {};
    bool done = false;
    while (done == false) {
      Console.WriteLine("Please chooose from the menu (Bread/Pastry/View Order)");
      string userInput = Console.ReadLine().ToUpper();
      if (userInput == "BREAD") {
        Console.WriteLine("How many loaves would you like?");
        string stringQuanity = Console.ReadLine();
        int quantity = int.Parse(stringQuanity);
        Bread addBread = new Bread(quantity);
        BreadOrder.Add(addBread);
      } else if (userInput == "VIEW" || userInput == "VIEW ORDER") {
        Console.WriteLine( quantity + "Bread: $" + breadtotal);
        Console.WriteLine( quantity + "Pastry: $" + pastrytotal);
        Console.WriteLine( "  Total: $" + ordertotal);
        // Console.WriteLine( "Would you like to modify your order? (Yes / No");
      }
    }
  }
}