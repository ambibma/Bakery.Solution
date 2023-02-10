using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;


namespace Bakery.Tests
{
  [TestClass]
  public class ProductsTests 
  {
    // public void Dispose()
    // {
    //   Product.ClearAll();
    // }
    [TestMethod]

    public void ProductConstructor_CreateInstanceOfProduct_Product()
    {
      Product newProduct = new Product(1);
      Assert.AreEqual(typeof(Product), newProduct.GetType());
    }
    [TestMethod]

    public void GetQuantity_ReturnsQuantity_Int()
    {
      int quantity = 1;
      Product newProduct = new Product(quantity);
      int result = newProduct.Quantity;
      Assert.AreEqual(quantity, result);
    }
    [TestMethod]

    public void GetPrice_ReturnsPrice_Int()
    {
      int quantity = 1;
      Product newProduct = new Product(quantity);
      newProduct.Price = 5;
      int result = newProduct.Price * quantity;
      Assert.AreEqual(5, result);
    }

    

  
  
  
  }

}