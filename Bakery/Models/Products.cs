using System.Collections.Generic;
// using System.Linq;

namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity {get;set;}
    private int _price = 5;
    public int FreeBread = 0;

   public Bread(int quantity)
    {
      Quantity = quantity;
      FreeBread = quantity/3;
      _price = _price * (quantity - FreeBread);
    } 
    
  }
  public class Pastry
  {
    public int Quantity {get; set;}
    private static int _price = 2;
    public int FreePastry= 0;

    public Pastry(int quantity)
    {
      Quantity = quantity;
      _price = _price * quantity;
    }

  }

  // public class Order
  // {

  // }


}