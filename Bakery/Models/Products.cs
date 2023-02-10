using System.Collections.Generic;
using System.Linq;

namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity {get;set;}
    public int Price {get; set;}
    // private static int _BreadCounter = new int ();

   public Bread(int quantity)
    {
      Quantity = quantity;
      Price = Price * quantity; 
    }
    
  }
  public class Pastry
  {
    // public int Quantity {get; set;}

  }

  public class Order
  {

  }


}