using System.Collections.Generic;
using System;

namespace PierresBakery.Models { 
  public class Pastry { 
    public int Quantity { get; set; }
    public Pastry(int quantity) {
      Quantity = quantity;
    }
    public int GetPrice(int quantity) {
      int price = 0;
      for (int i = 1 ; i <= quantity; i++) {
        if (!(i % 3 == 0)) {
          price = price + 2;          
        }
        else if (i % 3 == 0) {
          price = price + 1;
        }
      }
      return price;
    }
  }
}