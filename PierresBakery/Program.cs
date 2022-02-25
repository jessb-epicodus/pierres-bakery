using System.Collections.Generic;
using System;
using PierresBakery.Models;

class Program {
  public static void Main() {
    Console.WriteLine ("Welcome to Pierre's Bakery!");
    Console.WriteLine ("Bread: $5/ea | Buy 2 Get 1 FREE");
    Console.WriteLine ("Pastries: $2/ea | Buy 2 Get One 50% Off!");
  
    bool done = false;
    while (done == false) {
      Console.WriteLine("Chooose from the menu (Bread/Pastry/View Order)");

      Dictionary<string, int> Order = new Dictionary<string, int>() {};
      
      string userInput = Console.ReadLine().ToUpper();
      if (userInput == "BREAD") {
        Console.WriteLine("How many loaves would you like?");
        string stringQuanity = Console.ReadLine();
        int quantity = int.Parse(stringQuanity);
        Bread bread = new Bread(quantity);
        Order["Bread"] = bread.GetPrice(quantity);
        Console.WriteLine(quantity + "x Bread: $" + bread.GetPrice(quantity));
      } else if (userInput == "PASTRY") {
        Console.WriteLine("How many pastries would you like?");
        string stringQuanity = Console.ReadLine();
        int quantity = int.Parse(stringQuanity);
        Pastry pastry = new Pastry(quantity);
        Order["Pastry"] = pastry.GetPrice(quantity);
        Console.WriteLine(quantity + "x Pastry: $" + pastry.GetPrice(quantity));
      } else if (userInput == "VIEW" || userInput == "VIEW ORDER") {

      }
    }
  }
}