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
      Product newProduct = new Product();
      Assert.AreEqual(typeof(Product), newProduct.GetType());
    }
    // [TestMethod]

    // public void GetQuantity_ReturnsQuantity_Int()
    // {
    //   int quantity = 1;
    //   Product newProduct = new Product(quantity);
    //   int result = newProduct.Quantity;
    //   Assert.AreEqual(quantity, result);
    // }

  
  
  
  }

}