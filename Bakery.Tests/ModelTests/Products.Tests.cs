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

    public void BreadConstructor_CreateInstanceOfBread_Bread()
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

    public void GetPrice_ReturnsPrice_Int()
    {
      int quantity = 1;
      Bread newBread = new Bread(quantity);
      newBread.Price = 5;
      int result = newBread.Price * quantity;
      Assert.AreEqual(5, result);
    }  

  }
  [TestClass]
    public class PastryTests
    {
      [TestMethod]
      public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    }


}