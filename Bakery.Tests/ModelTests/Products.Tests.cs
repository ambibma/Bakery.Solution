using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;


namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests 
  {
    // public void Dispose()
    // {
    //   Bread.ClearAll();
    // }
    [TestMethod]

    public void BreadConstructor_CreateInstanceOfBread_getBread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]

    public void GetQuantity_ReturnsQuantity_Int()
    {
      int quantity = 1;
      Bread newBread = new Bread(quantity);
      int result = newBread.Quantity;
      Assert.AreEqual(quantity, result);
    }
    [TestMethod]

    public void GetFreeBread_ReturnsFreeBread_Int()
    {
      int quantity = 6;
      Bread newBread = new Bread(quantity);
      int freeBread = newBread.Quantity/3;
      int result = newBread.FreeBread;
      Assert.AreEqual(2, result);
    }
    [TestMethod]

    public void DisplayFreeBread_ShowsFreeBread_StringDescription()
    {
      int quantity = 3;
      Bread newBread = new Bread(quantity);
      string result = newBread.DisplayFreeBread();
      Assert.AreEqual($"Free Bread: {newBread.FreeBread}:", result);
    }
  } 
  
  [TestClass]
    public class PastryTests
    {
      [TestMethod]
      public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetQuantity_ReturnsQuantity_Int()
    {
      int quantity = 1;
      Pastry newPastry = new Pastry(quantity);
      int result = newPastry.Quantity;
      Assert.AreEqual(quantity, result);
    }
    [TestMethod]

    public void GetFreePastries_ReturnsFreePastries_Int()
    {
      int quantity = 4;
      Pastry newPastry = new Pastry(quantity);
      int freePastry = newPastry.Quantity/4;
      int result = newPastry.FreePastry;
      Assert.AreEqual(1, result);
    }
    
  }
}