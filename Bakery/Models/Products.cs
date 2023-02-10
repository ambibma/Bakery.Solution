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

    public string DisplayFreeBread()
    {      
      if (this.FreeBread == 0)
      {
        return "You did not qualify for any free loaves, come back nex time!";

      }
      if (this.FreeBread == 1)
      {
        return $"Free Bread: {this.FreeBread} Loaf!";
      }
      else
      {
        return $"Free Bread: {this.FreeBread} Loaves!";
      }
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
      FreePastry = quantity/4;
      _price = _price * (quantity - FreePastry);
    }

    public string DisplayFreePastries()
    {
      return "";
    }

  }

  
}
  // public class Order
  // {

  // }

