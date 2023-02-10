using System.Collections.Generic;
// using System.Linq;

namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity {get;set;}
    private int _price = 5;
    public int FreeBread = 0;
    // private static int _BreadCounter = new int ();

   public Bread(int quantity)
    {

      // if (quantity % 3)
      Quantity = quantity;
      // FreeBread = quantity/3;
      _price = _price * quantity;
    }
    // public int FreeBread()
    // {
    //   int cost = 0;
    //   int newCost = _price - cost;
    //   return newCost;
    
    // }
    
  }
  public class Pastry
  {
    public int Quantity {get; set;}
    private static int _price = 2;

    public Pastry(int quantity)
    {
      Quantity = quantity;
      _price = _price * quantity;
    }

  }

  public class Order
  {

  }


}