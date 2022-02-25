using System.Collections.Generic;
using System;

//// 1 for $2 or 3 for $5


namespace PierresBakery.Models { 
  public class Pastry { 
    public int Quantity { get; set; }
    public Pastry(int quantity) {
      Quantity = quantity;
    }
    public int GetPrice(int quantity) {
      return 0;
    }
  }
}