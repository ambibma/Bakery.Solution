using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;


namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests 
  {
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
      Assert.AreEqual($"Free Bread: {newBread.FreeBread} Loaf!", result);
    }
    [TestMethod]

    public void DisplayFreeBreads_ShowsFreeBreadLoaves_StringDescription()
    {
      int quantity = 6;
      Bread newBread = new Bread(quantity);
      string result = newBread.DisplayFreeBread();
      Assert.AreEqual($"Free Bread: {newBread.FreeBread} Loaves!", result);
    }
    [TestMethod]

    public void ShowBreadCost_ShowsCostOfBreadOrder_Int()
    {
      int quantity = 1;
      Bread newBread = new Bread(quantity);
      int result = newBread.ShowBreadCost();
      Assert.AreEqual(5, result);
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
      int freePastries = newPastry.Quantity/4;
      int result = newPastry.FreePastries;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void DisplayFreePastry_DisplaysFreePastry_StringDescription()
    {
      int quantity = 4;
      Pastry newPastry = new Pastry(quantity);
      string result = newPastry.DisplayFreePastries();
      Assert.AreEqual($"Free Pastries: {newPastry.FreePastries} Pastry!", result);
    }
    [TestMethod]
    public void DisplayFreePastries_DisplaysFreePastries_StringDescription()
    {
      int quantity = 8;
      Pastry newPastry = new Pastry(quantity);
      string result = newPastry.DisplayFreePastries();
      Assert.AreEqual($"Free Pastries: {newPastry.FreePastries} Pastries!", result);
    }
    [TestMethod]
    public void ShowPastryCost_ShowsCostOfPastryOrder_Int()
    {
      int quantity = 3;
      Pastry newPastry = new Pastry(quantity);
      int result = newPastry.ShowPastryCost();
      Assert.AreEqual(6, result);
    }

    
  }
}