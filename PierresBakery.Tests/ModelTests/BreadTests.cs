using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{

  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void CalcCost_ReturnsDataType_Int()
    {
      int userInput = 1;
      var result = Bread.CalcCost(userInput);
      Assert.IsInstanceOfType(result, typeof(int));
    }

    [TestMethod]
    public void BreadPrice_ReturnsDefaultBreadPrice_Int()
    {
      int defaultPrice = Bread.BreadPrice;
      Assert.AreEqual(5, defaultPrice);
    }

    [TestMethod]
    public void DiscountEvery_ReturnsDefaultDiscountEvery_Int()
    {
      int defaultDiscount = Bread.DiscountEvery;
      Assert.AreEqual(3, defaultDiscount);
    }

    [TestMethod]
    public void BreadPrice_GetSetNewValuesBreadPrice_Int()
    {
      Bread.BreadPrice = 12;
      int newPrice = Bread.BreadPrice;
      Assert.AreEqual(12, newPrice);
      Bread.BreadPrice = 5;
    }

    [TestMethod]
    public void DiscountEvery_GetSetNewValuesDiscountEvery_Int()
    {
      Bread.DiscountEvery = 4;
      int newDiscount = Bread.DiscountEvery;
      Assert.AreEqual(4, newDiscount);
      Bread.DiscountEvery = 3;
    }

    [TestMethod]
    public void CalcCost_CalcCostOfBreadLoaves_1Loaves_int()
    {
      int userInput = 1;
      int expectedReturn = Bread.CalcCost(userInput);
      Assert.AreEqual(5, expectedReturn);
    }

    [TestMethod]
    public void CalcCost_CalcCostOfBreadLoaves_50Loaves_int()
    {
      int userInput = 50;
      int expectedReturn = Bread.CalcCost(userInput);
      Assert.AreEqual(170, expectedReturn);
    }

    [TestMethod]
    public void CalcCost_CalcCostOfBreadLoaves_51Loaves_int()
    {
      int userInput = 51;
      int expectedReturn = Bread.CalcCost(userInput);
      Assert.AreEqual(170, expectedReturn);
    }
  }
}
