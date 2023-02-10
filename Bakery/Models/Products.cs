using System.Collections.Generic;
using System.Linq;

namespace Bakery.Models
{
  public class Product
  {
    public int Quantity {get;set;}
    public int Price {get; set;}
    // private static int _productCounter = new int ();

   public Product(int quantity)
    {
      Quantity = quantity;
      Price = Price * quantity; 
    }
    
  }
  public class Product : Pastries
  {

  }

  public class Order
  {

  }


}