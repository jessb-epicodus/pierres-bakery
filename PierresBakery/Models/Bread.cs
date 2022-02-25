using System.Collections.Generic;
using System;

//// single loaf costs $5, two loaves costs $10, and three loaves cost $10
//// Bread: Buy 2, get 1 free

namespace PierresBakery.Models {
  public class Bread { 
    public string AddBread { get; }
    public Bread (string addBread) {
      AddBread = addBread;
    }
  }
}