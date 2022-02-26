using System.Collections.Generic;
using System;
using PierresBakery.Models;

class Program {
  public static void Main() {
    Console.WriteLine ("Welcome to Pierre's Bakery!");
    Console.WriteLine ("Bread: $5/ea | Buy 2 Get 1 FREE");
    Console.WriteLine ("Pastries: $2/ea | Buy 2 Get One 50% Off!");
  Dictionary<string, int> bakeryOrder = new Dictionary<string, int>();
    bool done = false;
    while (done == false) {
      Console.WriteLine("Chooose from the menu (Bread/Pastry/View Order)");
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
      } else if (userInput == "VIEW" || userInput == "VIEW ORDER") {
        foreach (Item element in Order) {
        Console.WriteLine(element.GetQuantity);
        Console.WriteLine("$" + element.GetPrice);
      }
    }
  }
}