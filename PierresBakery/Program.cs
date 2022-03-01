using System.Collections.Generic;
using System;
using PierresBakery.Models;

class Program {  
  public static void Main() {
    Console.WriteLine ("      Welcome to Pierre's Bakery");
    Console.WriteLine ("    Bread: $5/ea | Buy 2 Get 1 FREE");
    Console.WriteLine (" Pastries: $2/ea | Buy 2 Get 1 50% Off");
    Console.WriteLine("--- -- - -- --- -- - -- --- -- - -- ---");
    bool done = false;
    while (done == false) {
      Console.WriteLine("How many loaves of bread would you like?");
      string stringLoaves = Console.ReadLine();
      int loaves = int.Parse(stringLoaves);
      Bread bread = new Bread(loaves);
      Console.WriteLine("How many pastries would you like?");
      string stringQuantity = Console.ReadLine();
      int quantity = int.Parse(stringQuantity);
      Pastry pastry = new Pastry(quantity);
      Console.WriteLine("--- -- - -- --- -- - -- --- -- - -- ---");
      Console.WriteLine("Your order:");
      Console.WriteLine(loaves + "x Bread: $" + bread.GetPrice(loaves));
      Console.WriteLine(quantity + "x Pastry: $" + pastry.GetPrice(quantity));
      Console.WriteLine("     Total: $" + (bread.GetPrice(loaves) + pastry.GetPrice(quantity)));
      Console.WriteLine("--- -- - -- --- -- - -- --- -- - -- ---");
      Console.WriteLine("Does everything on your order look correct? (Y / N)");
      string userInput = Console.ReadLine().ToUpper();
      if (userInput == "Y") {
        done = true;
        Console.WriteLine("Thank you! Enjoy :)");
      } else if (userInput == "N") {
        // loop back re-enter loaves and pastries
      }
    }
  }
}