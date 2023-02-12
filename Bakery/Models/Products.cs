
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
      
    }
    public string DisplayFreeBread()
    {      
      if (this.FreeBread == 0)
      {
        return "You did not qualify for any free loaves, come back next time!";

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
    public int GetBreadCost()
    {      
      _price = this._price * (Quantity - FreeBread);
      return _price;
    }
  }
  public class Pastry
  {
    public int Quantity {get; set;}
    private int _pastryCost = 2;
    public int FreePastries= 0;

    public Pastry(int quantity)
    {
      Quantity = quantity;
      FreePastries = quantity/4;
    }    
      public int GetPastryCost()
    {      
      _pastryCost = this._pastryCost * (Quantity - FreePastries);
      return _pastryCost;
    }
      public string DisplayFreePastries()
      {           
      if (this.FreePastries == 0)
      {
        return "You did not qualify for any free Pastries, come back next time!";
      }
      if (this.FreePastries == 1)
      {
        return $"Free Pastries: {this.FreePastries} Pastry!";
      }
      else
      {
        return $"Free Pastries: {this.FreePastries} Pastries!";
      }
      }
  }
}      
