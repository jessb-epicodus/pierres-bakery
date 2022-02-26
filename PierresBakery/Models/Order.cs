namespace PierresBakery.Models {
  public class Order { 
    public string Item { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
    public Order(string item, int quantity, int price)
    {
      Item = item;
      Quantity = quantity;
      Price = price;
    }
      public string GeItem()
    {
      return Item;
    }

    public int GetQuantity()
    {
      return Quantity;
    }

    public int GetPrice()
    {
      return Price;
    }    
  }
}