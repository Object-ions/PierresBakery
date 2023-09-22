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
