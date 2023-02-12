using System;
using Bakery.Models;


namespace Bakery {
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! Home of the Pierre's Poppin' Pastry!");
      Console.WriteLine("Bread is $5.00 Each"); 
      Console.WriteLine("Poppin' Pastries are: $2.00"); 
      Console.WriteLine("TODAY'S SALE: Buy 2 Loaves of Bread and the 3rd is Free & Buy 3 Poppin' Pastries get one Free!");
      Console.WriteLine("Note: If you Buy 2 Loaves or 3 Pastries add 1 the free one to your order!, otherwise we just might forget");


      while (true)
      {
        Console.WriteLine("Would you like to place an order?   (Yes/No)");
        string userInput = Console.ReadLine();
        if (userInput.ToLower() == "yes")
        {
          Console.WriteLine("How many loaves of Bread would you like?");
          int userBreadQuantity = int.Parse(Console.ReadLine());
          Bread newBread = new Bread(userBreadQuantity);
          Console.WriteLine(newBread.DisplayFreeBread());
          Console.WriteLine("Your Bread Cost is " + "$"+newBread.GetBreadCost()+".00");
          Console.WriteLine("How many Poppin' Pastries would you like?");
          int userPastryQuantity = int.Parse(Console.ReadLine());
          Pastry newPastry = new Pastry(userPastryQuantity);
          Console.WriteLine(newPastry.DisplayFreePastries());
          Console.WriteLine("Your Pastry Order cost is " + "$"+newPastry.ShowPastryCost()+".00");
          Console.WriteLine("Your total Cost comes out to: " +"$"+(newBread.GetBreadCost()+newPastry.ShowPastryCost())+ ".00");
          Console.WriteLine("Thank you for stopping at Pierre's Bakery have a nice day!");
        }
        else
        {
          Console.WriteLine("Okay then have a nice day!");
        }
      }
    }
  }
}